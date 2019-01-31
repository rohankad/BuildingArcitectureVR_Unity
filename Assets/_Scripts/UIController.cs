using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	public GameObject _Loading;
	public GameObject _exterior, _interior;
	// Use this for initialization

	bool IsSelected;
	void Start () {
		IsSelected = false;

	//	Invoke ("ExteriorSelected", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.JoystickButton0)) {
			
			//SceneManager.LoadSceneAsync ("Interior");
			//Application.LoadLevelAsync("Interior");
	
			if (IsSelected == false) {
				print ("Down INTERIOR");
				InteriorSelected ();
				IsSelected = true;
			}
		} else if (Input.GetKeyUp (KeyCode.JoystickButton3)) {
			
			//SceneManager.LoadSceneAsync ("Exterior");
			//Application.LoadLevelAsync("Exterior");

			if (IsSelected == false) {
				print ("up EXTERIOR");
				ExteriorSelected ();
				IsSelected = true;
			}
		}
	}

	public void InteriorSelected(){
		//Application.LoadLevelAsync("Interior_New");
		_exterior.SetActive (false);
		_interior.SetActive(false);
		_Loading.SetActive(true);

		SceneManager.LoadSceneAsync ("Final_Interior");
	}

	public void ExteriorSelected(){
		_exterior.SetActive (false);
		_interior.SetActive(false);
		_Loading.SetActive(true);
		//Application.LoadLevelAsync("Exterior_New");
		SceneManager.LoadSceneAsync ("Exterior");
	}
}
