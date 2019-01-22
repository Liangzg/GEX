﻿/********************************************************************************
** Author： LiangZG
** Email :  game.liangzg@foxmail.com
*********************************************************************************/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIPageRoot : MonoBehaviour
{
    private static UIPageRoot m_Instance = null;
    public static UIPageRoot Instance
    {
        get
        {
            if(m_Instance == null)
            {
                InitRoot();
            }
            return m_Instance;
        }
    }

    private static Vector2 screenResolution = new Vector2(1280 , 720);

    public Transform root;
    public Transform fixedRoot;
    public Transform normalRoot;
    public Transform popupRoot;
    public Camera uiCamera;

    static void InitRoot()
    {
        GameObject go = new GameObject("UIRoot");
        go.layer = LayerMask.NameToLayer("UI");
        m_Instance = go.AddComponent<UIPageRoot>();
        go.AddComponent<RectTransform>();
        m_Instance.root = go.transform;


        GameObject camObj = new GameObject("UICamera");
        camObj.layer = LayerMask.NameToLayer("UI");
        camObj.transform.parent = go.transform;
        camObj.transform.localPosition = new Vector3(0,0,-100f);

        Camera cam = camObj.AddComponent<Camera>();
        cam.clearFlags = CameraClearFlags.Depth;
        cam.orthographic = true;
        cam.farClipPlane = 200f;
        
        m_Instance.uiCamera = cam;
        cam.cullingMask = 1<<5;
        cam.nearClipPlane = -50f;
        cam.farClipPlane = 50f;

//        Canvas can = go.AddComponent<Canvas>();
//        can.renderMode = RenderMode.ScreenSpaceCamera;
//        can.pixelPerfect = true;
//        can.worldCamera = cam;

        //add audio listener
        camObj.AddComponent<AudioListener>();
        camObj.AddComponent<GUILayer>();

//        CanvasScaler cs = go.AddComponent<CanvasScaler>();
//        cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
//        cs.referenceResolution = screenResolution;
//        cs.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        GameObject subRoot = CreateSubCanvasForRoot(go.transform,250);
        subRoot.name = "FixedRoot";
        m_Instance.fixedRoot = subRoot.transform;

        subRoot = CreateSubCanvasForRoot(go.transform,0);
        subRoot.name = "NormalRoot";
        m_Instance.normalRoot = subRoot.transform;

        subRoot = CreateSubCanvasForRoot(go.transform,500);
        subRoot.name = "PopupRoot";
        m_Instance.popupRoot = subRoot.transform;

        //add Event System
        GameObject esObj = GameObject.Find("EventSystem");
        if(esObj != null)
        {
            GameObject.DestroyImmediate(esObj);
        }

        GameObject eventObj = new GameObject("EventSystem");
        eventObj.layer = LayerMask.NameToLayer("UI");
        eventObj.transform.SetParent(go.transform);
        eventObj.AddComponent<EventSystem>();
        if (!Application.isMobilePlatform || Application.isEditor)
        {
            eventObj.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
        }
        else
        {
            eventObj.AddComponent<UnityEngine.EventSystems.TouchInputModule>();
        }
    }

    static GameObject CreateSubCanvasForRoot(Transform root,int sort)
    {
        GameObject go = new GameObject("canvas");
        go.transform.parent = root;
        go.layer = LayerMask.NameToLayer("UI");
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.transform.localRotation = Quaternion.identity;

//        Canvas can = go.AddComponent<Canvas>();
//        RectTransform rect = go.GetComponent<RectTransform>();
//        rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, 0);
//        rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, 0);
//        rect.anchorMin = Vector2.zero;
//        rect.anchorMax = Vector2.one;
//
//        can.overrideSorting = true;
//        can.sortingOrder = sort;
//
//        go.AddComponent<GraphicRaycaster>();

        return go;
    }

    /// <summary>
    /// 获得对应Page类型的Root
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Transform GetRoot(EPageType type)
    {
        if(type == EPageType.Fixed)     return fixedRoot;
        if(type == EPageType.Normal)    return normalRoot;
        if(type == EPageType.PopUp)     return popupRoot;

        return m_Instance.root;
    }

    void OnDestroy()
    {
        m_Instance = null;
    }
}
