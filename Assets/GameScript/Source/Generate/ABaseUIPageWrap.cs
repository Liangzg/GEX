﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ABaseUIPageWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ABaseUIPage), typeof(System.Object));
		L.RegFunction("OnAwake", OnAwake);
		L.RegFunction("OnShow", OnShow);
		L.RegFunction("OnHide", OnHide);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("SetPage", SetPage);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("BackQueue", get_BackQueue, set_BackQueue);
		L.RegVar("CacheGameObject", get_CacheGameObject, null);
		L.RegVar("CacheTrans", get_CacheTrans, null);
		L.RegVar("AttributePage", get_AttributePage, null);
		L.RegVar("Active", get_Active, set_Active);
		L.RegVar("Name", get_Name, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAwake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ABaseUIPage obj = (ABaseUIPage)ToLua.CheckObject(L, 1, typeof(ABaseUIPage));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.OnAwake(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnShow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ABaseUIPage obj = (ABaseUIPage)ToLua.CheckObject(L, 1, typeof(ABaseUIPage));
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.OnShow(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnHide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ABaseUIPage obj = (ABaseUIPage)ToLua.CheckObject(L, 1, typeof(ABaseUIPage));
			obj.OnHide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ABaseUIPage obj = (ABaseUIPage)ToLua.CheckObject(L, 1, typeof(ABaseUIPage));
			obj.OnDestroy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			ABaseUIPage obj = (ABaseUIPage)ToLua.CheckObject(L, 1, typeof(ABaseUIPage));
			EPageType arg0 = (EPageType)ToLua.CheckObject(L, 2, typeof(EPageType));
			EShowMode arg1 = (EShowMode)ToLua.CheckObject(L, 3, typeof(EShowMode));
			ECollider arg2 = (ECollider)ToLua.CheckObject(L, 4, typeof(ECollider));
			obj.SetPage(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BackQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			System.Collections.Generic.List<string> ret = obj.BackQueue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index BackQueue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheGameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			UnityEngine.GameObject ret = obj.CacheGameObject;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CacheGameObject on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CacheTrans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			UnityEngine.Transform ret = obj.CacheTrans;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CacheTrans on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AttributePage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			PageAttribute ret = obj.AttributePage;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index AttributePage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			bool ret = obj.Active;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Active on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			string ret = obj.Name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Name on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BackQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
			obj.BackQueue = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index BackQueue on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ABaseUIPage obj = (ABaseUIPage)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Active = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Active on a nil value" : e.Message);
		}
	}
}
