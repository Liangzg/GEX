﻿using System;
using System.IO;
using UnityEngine;

namespace GEX.Resource
{
    /// <summary>
    /// 处理异步加载AssetBundle
    /// </summary>
    public class LoadBundleAsync : LoadOperation
    {
        private bool isDone = false;
        private string extension;
        private GameObject owner;

        private UnityEngine.Object mainAsset;

        public LoadBundleAsync(GameObject owner, string assetName) : base(assetName)
        {
            this.extension = Path.GetExtension(extension);
            this.owner = owner;
        }

        public override void OnLoad()
        {
            if (extension == ".prefab")
            {
                AssetBundleManager.Instance.LoadPrefabAsync(assetPath)
                    .Then((gObj) => loadFinishCallback(gObj));
            }
            else
            {
                AssetBundleManager.Instance.LoadAssetAsync<UnityEngine.Object>(assetPath, extension, owner)
                    .Then((gObj) => loadFinishCallback(gObj));
            }
        }

        private void loadFinishCallback(UnityEngine.Object gameObject)
        {
            this.mainAsset = gameObject;
            isDone = true;

            this.onFinishEvent();
        }

        public override bool IsDone()
        {
            return isDone;
        }

        public override T GetAsset<T>()
        {
            return mainAsset as T;
        }
    }
}
