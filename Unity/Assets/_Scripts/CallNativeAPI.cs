using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class CallNativeAPI { 
	
#if UNITY_EDITOR 
	public static void PresentUnityAnimated() {
		return;
	}
	public static void DismissUnityAnimated() {
		return;
	}
#elif UNITY_IPHONE 
	[ DllImport( "__Internal" )]
	public static extern void PresentUnityAnimated ();
	[ DllImport( "__Internal" )]
	public static extern void DismissUnityAnimated ();
#elif UNITY_ANDROID 
	[DllImport ("libtestunity", CallingConvention = CallingConvention.Cdecl)] 
	public static extern void PresentUnityAnimated ();
	[DllImport ("libtestunity", CallingConvention = CallingConvention.Cdecl)] 
	public static extern void DismissUnityAnimated ();
#endif   
} 
