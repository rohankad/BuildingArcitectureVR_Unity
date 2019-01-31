using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RotateAround : MonoBehaviour {

	public GameObject _Target;

	public float _Distance;

	//public GameObject _InteriorCam;
	//public GameObject _ExteriorCam;

	// Use this for initialization
	void Start () {
		_Distance = Vector3.Distance (this.transform.position, _Target.transform.position);
	//	Invoke ("InteriorSelected", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		_Distance = Vector3.Distance (this.transform.position, _Target.transform.position);
			//transform.LookAt (_Target.transform.position);

			if (Input.GetAxis ("Horizontal") < 0) {
				transform.RotateAround (_Target.transform.position, -Vector3.up, 20 * Time.deltaTime);
			} else if (Input.GetAxis ("Horizontal") > 0) {
				transform.RotateAround (_Target.transform.position, Vector3.up, 20 * Time.deltaTime);
			} 

		if (Input.GetAxis ("Vertical") < 0) {
			print ("Distance : "+_Distance);
			//transform.RotateAround (_Target.transform.position, -Vector3.up, 20 * Time.deltaTime);
			//if(transform.position.z>1.5f)
			if (_Distance < 12f)
			transform.Translate(Vector3.back*Time.deltaTime*10);// = Vector3.forward*Time.deltaTime;

		} else if (Input.GetAxis ("Vertical") > 0) { //Zoom
			//transform.RotateAround (_Target.transform.position, Vector3.up, 20 * Time.deltaTime);
			if (_Distance > 6f) {
				print ("Distance : " + _Distance);
				transform.Translate (-Vector3.back * Time.deltaTime*10);
			}
		} 
		

		if(Input.GetKeyUp(KeyCode.JoystickButton6)){
		//	print ("BACK");
			//SceneManager.LoadSceneAsync ("UI");
			//Application.LoadLevelAsync("UI");
			SceneManager.LoadSceneAsync ("UI");

		}
		if(Input.GetKeyUp(KeyCode.JoystickButton8))
			print ("BACK8"); //

		if(Input.GetKeyUp(KeyCode.JoystickButton9))
			print ("BACK9"); //

		if(Input.GetKeyUp(KeyCode.JoystickButton10))
			print ("BACK10"); //

		if(Input.GetKeyUp(KeyCode.JoystickButton11))
			print ("BACK11"); //

	

		//4,5,6,7 NA
		if(Input.GetKeyUp(KeyCode.JoystickButton0))
			print ("BACK0"); //A

		if(Input.GetKeyUp(KeyCode.JoystickButton1))
			print ("BACK1"); //E

		if(Input.GetKeyUp(KeyCode.JoystickButton2))
			print ("BACK2"); //X

		if(Input.GetKeyUp(KeyCode.JoystickButton3))
			print ("BACK3"); //Y

		if(Input.GetKeyUp(KeyCode.JoystickButton4))
			print ("BACK4"); //A

		if(Input.GetKeyUp(KeyCode.JoystickButton5))
			print ("BACK5"); //E

		if(Input.GetKeyUp(KeyCode.JoystickButton6))
			print ("BACK6"); //X

		if(Input.GetKeyUp(KeyCode.JoystickButton7))
			print ("BACK7"); //Y

	}
	//  transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

	public void InteriorSelected(){

		SceneManager.LoadSceneAsync ("Final_Interior");
	}
}
