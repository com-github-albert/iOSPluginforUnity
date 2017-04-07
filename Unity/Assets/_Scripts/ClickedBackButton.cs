using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class ClickedBackButton : MonoBehaviour {

	public void Clicked() {
		Debug.Log ("press");
		if (Application.platform == RuntimePlatform.IPhonePlayer) {  
			CallNativeAPI.DismissUnityAnimated();  
		}
	}	
}
