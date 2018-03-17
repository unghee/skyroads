using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fallout : MonoBehaviour {

	public Transform respawn;
	public GameObject player;
	public Text gameovertext;
	public Text restarttext;

	private bool restart;

	// Use this for initialization
	void Start () {
		gameovertext.text = "";
		restarttext.text = "";
		restart = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (restart) {
			if (Input.GetKeyDown (KeyCode.R)){
				//Application.LoadLevel (Application.LoadLevel);
//				restart = true;
				SceneManager.LoadScene( SceneManager.GetActiveScene().name );
			}


		}
		
	}
		
	void OnTriggerEnter(Collider other) {

//		player.transform.position = respawn.position;
		//game over 
		gameovertext.text = "GAME OVER";
		restarttext.text = "Press 'R' for Restart";
		restart = true;
		Time.timeScale = 0;
	}
}
