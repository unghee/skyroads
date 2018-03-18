using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class speedgauge : MonoBehaviour {
	public Image fillImg;
//	float timeAmt = 10;
//	float time;
	public float waitTime = 30.0f;
	private float amount;
	private float speedo;

	// Use this for initialization
	void Start () {
		fillImg = this.GetComponent<Image> ();
		fillImg.fillAmount = 0.1f;
	}
	
	// Update is called once per frame
//	void Update () {
////		if (time > 0) {
////			time -= Time.deltaTime;
//			fillImg.fillAmount -= 1.0f / waitTime * Time.deltaTime;
//		amount  -= 1.0f / waitTime * Time.deltaTime;
//		print(amount);
//
////		}
//	}
	void Update () {
		fillImg.fillAmount  =(float)Playercontroller.boltcount/3;
		print (Playercontroller.boltcount/3);
	}
}
