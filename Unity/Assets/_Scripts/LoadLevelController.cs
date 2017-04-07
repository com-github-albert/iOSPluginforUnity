using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevelController: MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {  
			CallNativeAPI.PresentUnityAnimated();  
		} 
	}

	/// <summary>
	/// Get Message From iOS Plugins
	/// </summary>

	public void LoadLevelWithName(string name) {
		switch (name) {
		case "Empty":
			SceneManager.LoadScene(0);
			break;
		case "Robot":
			SceneManager.LoadScene(1);
			break;
		case "Video":
			SceneManager.LoadScene(2);
			break;
		default:
			break;
		}
	}
}
