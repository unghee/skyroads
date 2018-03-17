using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private Vector3 moreOffset;

	// Use this for initialization
	void Start () {
		moreOffset [0] = 0;
		moreOffset [1] = 0;
		moreOffset [2] = -10;
	
		offset = transform.position - player.transform.position + moreOffset;
	}
	
	// Update is called once per frame
	void Update () {


		transform.position = player.transform.position + offset;
	}
}
