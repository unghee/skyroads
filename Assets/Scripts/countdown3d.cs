using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown3d : MonoBehaviour {

	[SerializeField]
	public float CountdownFrom;
	[SerializeField]
	public Text CountdownText;
//	public GameObject 3D

	void Start() {
		if (CountdownText == null) {
			Debug.LogError("STATUS INDICATOR: No text object referenced!");
			GetComponent<TextMesh>().text = "Ready";
		}
	}
	void Update()
	{
		float time = CountdownFrom - Time.timeSinceLevelLoad;
		GetComponent<TextMesh>().text  = "Time left: " + time.ToString("0") + "s";

		if (time <= 0f)
		{
			TimeUp();
		}
	}

	void TimeUp()
	{
		Destroy(gameObject);
	}
}
