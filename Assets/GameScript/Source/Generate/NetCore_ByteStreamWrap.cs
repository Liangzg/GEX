﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NetCore_ByteStreamWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NetCore.ByteStream), typeof(System.Object));
		L.RegFunction("readInt8", readInt8);
		L.RegFunction("writeInt8", writeInt8);
		L.RegFunction("readInt16", readInt16);
		L.RegFunction("writeInt16", writeInt16);
		L.RegFunction("readInt32", readInt32);
		L.RegFunction("writeInt32", writeInt32);
		L.RegFunction("readInt64", readInt64);
		L.RegFunction("writeInt64", writeInt64);
		L.RegFunction("readString", readString);
		L.RegFunction("writeString", writeString);
		L.RegFunction("byteBuffer", byteBuffer);
		L.RegFunction("attachBuffer", attachBuffer);
		L.RegFunction("detachBuffer", detachBuffer);
		L.RegFunction("New", _CreateNetCore_ByteStream);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNetCore_ByteStream(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NetCore.ByteStream obj = new NetCore.ByteStream();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NetCore.ByteStream.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt8(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			byte o = obj.readInt8();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt8(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt8(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt16(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			short o = obj.readInt16();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt16(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			short arg0 = (short)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt16(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			int o = obj.readInt32();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt32(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			long o = obj.readInt64();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			long arg0 = (long)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt64(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			string o = obj.readString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			string arg0 = ToLua.CheckString(L, 2);
			obj.writeString(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int byteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			NetCore.ByteArray o = obj.byteBuffer();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int attachBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			NetCore.ByteArray arg0 = (NetCore.ByteArray)ToLua.CheckObject(L, 2, typeof(NetCore.ByteArray));
			obj.attachBuffer(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int detachBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteStream obj = (NetCore.ByteStream)ToLua.CheckObject(L, 1, typeof(NetCore.ByteStream));
			obj.detachBuffer();
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
}
