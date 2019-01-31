using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIInterior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Invoke ("ExteriorSelected", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKeyUp(KeyCode.JoystickButton2)){ //X
		//	print ("BACK");
			//SceneManager.LoadSceneAsync ("UI");
			//Application.LoadLevelAsync("UI");
		//}


		if(Input.GetKeyUp(KeyCode.JoystickButton6)){
			//	print ("BACK");
			//SceneManager.LoadSceneAsync ("UI");
			//Application.LoadLevelAsync("UI");
			SceneManager.LoadSceneAsync ("UI");
		}
	}

	public void InteriorSelected(){
		//SceneManager.LoadSceneAsync ("Final_Interior");
	}
}
