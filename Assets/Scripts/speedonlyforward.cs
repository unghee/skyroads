using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedonlyforward : MonoBehaviour {

//	public GameObject player;
	public Rigidbody rb;
	private Vector3	currrentVelocity;
	private float xv,yv,zv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}


//	void OnTriggerEnter(Collider other) {
	void OnCollisionEnter (Collision collision){

		//		player.transform.position = respawn.position;
		//game over 
		currrentVelocity = rb.velocity;
		xv = currrentVelocity.x;
		yv = currrentVelocity.y;
		zv = currrentVelocity.z;

		print("isit colliding");
		rb.velocity = new Vector3(0, yv, zv);

	}

}
