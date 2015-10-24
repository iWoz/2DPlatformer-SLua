﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_SphericalHarmonicsL2 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 o;
			o=new UnityEngine.Rendering.SphericalHarmonicsL2();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			self.Clear();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddAmbientLight(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.AddAmbientLight(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddDirectionalLight(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.AddDirectionalLight(a1,a2,a3);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.Rendering.SphericalHarmonicsL2))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.Rendering.SphericalHarmonicsL2 a2;
				checkValueType(l,2,out a2);
				var ret=a1*a2;
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Rendering.SphericalHarmonicsL2),typeof(float))){
				UnityEngine.Rendering.SphericalHarmonicsL2 a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=a1*a2;
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Addition(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkValueType(l,2,out a2);
			var ret=a1+a2;
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SphericalHarmonicsL2");
		addMember(l,Clear);
		addMember(l,AddAmbientLight);
		addMember(l,AddDirectionalLight);
		addMember(l,op_Multiply);
		addMember(l,op_Addition);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.SphericalHarmonicsL2),typeof(System.ValueType));
	}
}
