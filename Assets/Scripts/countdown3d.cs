using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown3d : MonoBehaviour {

	[SerializeField]
//	public float CountdownFrom;
	private float CountdownFrom;
	[SerializeField]
//	public Text CountdownText;
//	public GameObject 3D

	void Start() {
//		if (CountdownText == null) {
//			Debug.LogError("STATUS INDICATOR: No text object referenced!");
			GetComponent<TextMesh>().text = "Ready";
		CountdownFrom = 5.0f;
//		}
	}
	void Update()
	{
		
		float timeDisplay = CountdownFrom - Time.timeSinceLevelLoad;
//		float time = Time.timeSinceLevelLoad;
//		GetComponent<TextMesh>().text  = "Time left: " + time.ToString("0") + "s";

		if (timeDisplay <= 3f && timeDisplay > 0f) {
			GetComponent<TextMesh> ().text = timeDisplay.ToString ("0");
		}
		else if (timeDisplay <= 0f)
		{
//			TimeUp();
			GetComponent<TextMesh>().text = "START!!";
		}
	}

//	void TimeUp()
//	{
//		Destroy(gameObject);
//	}
}
