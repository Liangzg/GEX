﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using System.Collections.Generic;
using LuaInterface;

public static class DelegateFactory
{
	public delegate Delegate DelegateValue(LuaFunction func);
	public static Dictionary<Type, DelegateValue> dict = new Dictionary<Type, DelegateValue>();

	static DelegateFactory()
	{
		Register();
	}

	[NoToLuaAttribute]
	public static void Register()
	{
		dict.Clear();
		dict.Add(typeof(System.Action), System_Action);
		dict.Add(typeof(System.Action<UnityEngine.GameObject>), System_Action_UnityEngine_GameObject);
		dict.Add(typeof(UnityEngine.Events.UnityAction), UnityEngine_Events_UnityAction);
		dict.Add(typeof(UnityEngine.Camera.CameraCallback), UnityEngine_Camera_CameraCallback);
		dict.Add(typeof(UnityEngine.Application.LogCallback), UnityEngine_Application_LogCallback);
		dict.Add(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), UnityEngine_Application_AdvertisingIdentifierCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMReaderCallback), UnityEngine_AudioClip_PCMReaderCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), UnityEngine_AudioClip_PCMSetPositionCallback);
		dict.Add(typeof(NetCore.Net.NetError), NetCore_Net_NetError);
		dict.Add(typeof(System.Action<byte[]>), System_Action_bytes);
		dict.Add(typeof(System.Action<float,float>), System_Action_float_float);
		dict.Add(typeof(System.Action<object>), System_Action_object);
		dict.Add(typeof(System.Action<UnityEngine.AssetBundle>), System_Action_UnityEngine_AssetBundle);
		dict.Add(typeof(UnityEngine.GUI.WindowFunction), UnityEngine_GUI_WindowFunction);
		dict.Add(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties), UnityEngine_RectTransform_ReapplyDrivenProperties);
	}

    [NoToLuaAttribute]
    public static Delegate CreateDelegate(Type t, LuaFunction func = null)
    {
        DelegateValue create = null;

        if (!dict.TryGetValue(t, out create))
        {
            throw new LuaException(string.Format("Delegate {0} not register", LuaMisc.GetTypeName(t)));            
        }
        
        return create(func);        
    }

    [NoToLuaAttribute]
    public static Delegate RemoveDelegate(Delegate obj, LuaFunction func)
    {
        LuaState state = func.GetLuaState();
        Delegate[] ds = obj.GetInvocationList();

        for (int i = 0; i < ds.Length; i++)
        {
            LuaDelegate ld = ds[i].Target as LuaDelegate;

            if (ld != null && ld.func == func)
            {
                obj = Delegate.Remove(obj, ds[i]);
                state.DelayDispose(ld.func);
                break;
            }
        }

        return obj;
    }

	class System_Action_Event : LuaDelegate
	{
		public System_Action_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate System_Action(LuaFunction func)
	{
		if (func == null)
		{
			System.Action fn = delegate { };
			return fn;
		}

		System.Action d = (new System_Action_Event(func)).Call;
		return d;
	}

	class System_Action_UnityEngine_GameObject_Event : LuaDelegate
	{
		public System_Action_UnityEngine_GameObject_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.GameObject param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_UnityEngine_GameObject(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<UnityEngine.GameObject> fn = delegate { };
			return fn;
		}

		System.Action<UnityEngine.GameObject> d = (new System_Action_UnityEngine_GameObject_Event(func)).Call;
		return d;
	}

	class UnityEngine_Events_UnityAction_Event : LuaDelegate
	{
		public UnityEngine_Events_UnityAction_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UnityEngine_Events_UnityAction(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Events.UnityAction fn = delegate { };
			return fn;
		}

		UnityEngine.Events.UnityAction d = (new UnityEngine_Events_UnityAction_Event(func)).Call;
		return d;
	}

	class UnityEngine_Camera_CameraCallback_Event : LuaDelegate
	{
		public UnityEngine_Camera_CameraCallback_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.Camera param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Camera_CameraCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Camera.CameraCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Camera.CameraCallback d = (new UnityEngine_Camera_CameraCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_LogCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LogCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,string param1,UnityEngine.LogType param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_LogCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.LogCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.LogCallback d = (new UnityEngine_Application_LogCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_AdvertisingIdentifierCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_AdvertisingIdentifierCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,bool param1,string param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_AdvertisingIdentifierCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.AdvertisingIdentifierCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.AdvertisingIdentifierCallback d = (new UnityEngine_Application_AdvertisingIdentifierCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMReaderCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func) : base(func) { }

		public void Call(float[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMReaderCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMReaderCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMReaderCallback d = (new UnityEngine_AudioClip_PCMReaderCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMSetPositionCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func) : base(func) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMSetPositionCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMSetPositionCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMSetPositionCallback d = (new UnityEngine_AudioClip_PCMSetPositionCallback_Event(func)).Call;
		return d;
	}

	class NetCore_Net_NetError_Event : LuaDelegate
	{
		public NetCore_Net_NetError_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate NetCore_Net_NetError(LuaFunction func)
	{
		if (func == null)
		{
			NetCore.Net.NetError fn = delegate { };
			return fn;
		}

		NetCore.Net.NetError d = (new NetCore_Net_NetError_Event(func)).Call;
		return d;
	}

	class System_Action_bytes_Event : LuaDelegate
	{
		public System_Action_bytes_Event(LuaFunction func) : base(func) { }

		public void Call(byte[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_bytes(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<byte[]> fn = delegate { };
			return fn;
		}

		System.Action<byte[]> d = (new System_Action_bytes_Event(func)).Call;
		return d;
	}

	class System_Action_float_float_Event : LuaDelegate
	{
		public System_Action_float_float_Event(LuaFunction func) : base(func) { }

		public void Call(float param0,float param1)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_float_float(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<float,float> fn = delegate { };
			return fn;
		}

		System.Action<float,float> d = (new System_Action_float_float_Event(func)).Call;
		return d;
	}

	class System_Action_object_Event : LuaDelegate
	{
		public System_Action_object_Event(LuaFunction func) : base(func) { }

		public void Call(object param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_object(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<object> fn = delegate { };
			return fn;
		}

		System.Action<object> d = (new System_Action_object_Event(func)).Call;
		return d;
	}

	class System_Action_UnityEngine_AssetBundle_Event : LuaDelegate
	{
		public System_Action_UnityEngine_AssetBundle_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.AssetBundle param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_UnityEngine_AssetBundle(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<UnityEngine.AssetBundle> fn = delegate { };
			return fn;
		}

		System.Action<UnityEngine.AssetBundle> d = (new System_Action_UnityEngine_AssetBundle_Event(func)).Call;
		return d;
	}

	class UnityEngine_GUI_WindowFunction_Event : LuaDelegate
	{
		public UnityEngine_GUI_WindowFunction_Event(LuaFunction func) : base(func) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_GUI_WindowFunction(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.GUI.WindowFunction fn = delegate { };
			return fn;
		}

		UnityEngine.GUI.WindowFunction d = (new UnityEngine_GUI_WindowFunction_Event(func)).Call;
		return d;
	}

	class UnityEngine_RectTransform_ReapplyDrivenProperties_Event : LuaDelegate
	{
		public UnityEngine_RectTransform_ReapplyDrivenProperties_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.RectTransform param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_RectTransform_ReapplyDrivenProperties(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.RectTransform.ReapplyDrivenProperties fn = delegate { };
			return fn;
		}

		UnityEngine.RectTransform.ReapplyDrivenProperties d = (new UnityEngine_RectTransform_ReapplyDrivenProperties_Event(func)).Call;
		return d;
	}

}
