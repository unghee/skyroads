using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour {


	public Text stageclear;
	private bool restart;

	// Use this for initialization
	void Start () {
		stageclear.text = "";
	}
	
	// Update is called once per frame


	void Update () {
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R)){
				//Application.LoadLevel (Application.LoadLevel);
				//				restart = true;
				SceneManager.LoadScene( SceneManager.GetActiveScene().name );
				Time.timeScale = 1.0f;
			}


		}

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			other.gameObject.SetActive (false);
			stageclear.text = "STAGE CLEAR";
			restart = true;
			Time.timeScale = 0;
		}
	}

}