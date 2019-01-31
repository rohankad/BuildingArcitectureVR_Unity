using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

	public GameObject _ExteriorCam;
	public GameObject _InteriorCam;

	// Use this for initialization
	void Start () {
//		Invoke ("ChangeCam",5f);
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKeyUp(KeyCode.JoystickButton6)){
				
		
		
		//	ChangeCam ();
		//}
	}

//	void ChangeCam(){
//		print ("changing scene");
//		if (_ExteriorCam.activeInHierarchy) {
//			_ExteriorCam.SetActive (false);
//			_InteriorCam.SetActive (true);
//		} else {
//			_InteriorCam.SetActive (false);
//			_ExteriorCam.SetActive (true);
//		}
//		Invoke ("ChangeCam",10f);
//	}



}
