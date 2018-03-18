using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour {

	public static float speed;
	private float distToGround;
	private float i;
	public static int boltcount;
	private Rigidbody rb;
	private Collider m_Collider;
	public GameObject Countdown3d;


	void Start()
	{

		rb = GetComponent<Rigidbody> ();
		m_Collider = GetComponent<Collider>();

		distToGround = m_Collider.bounds.extents.y;
		speed = 5.0f;
		boltcount = 0; 
	}

	bool IsGrounded(){
//		return Physics.Raycast(transform.position, -Vector3.up,  0.1);
		return Physics.Raycast(transform.position, -Vector3.up,  distToGround+ 0.1f);
	}

	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


		Vector3 fixedmovement = new Vector3 (0, 0.0f, 1);
		Vector3 jumpmovement = new Vector3 (0, 1, 0);
		Vector3 Right = new Vector3 (20, 0, 0);
		Vector3 Left = new Vector3 (-20, 0, 0);


		rb.AddForce (movement*speed*2);

		if (Countdown3d.GetComponent<TextMesh> ().text == "START!!") 
		{
			rb.AddForce (fixedmovement * speed *(1+0.3f*(boltcount+1)));

//			while (Input.GetKeyDown (KeyCode.UpArrow)) {
//				i = i + 1;
//				speed = speed + i;
//				rb.AddForce (fixedmovement * speed);
//			}

		}

		print (IsGrounded ());
//		print (Countdown3d.GetComponent<TextMesh> ().text);

		if (Input.GetKey (KeyCode.Space) && IsGrounded())  
		{ 
			rb.AddForce (jumpmovement, ForceMode.Impulse);
//			rb.AddForce (jumpmovement);

		}

//		if (Input.GetKeyDown (KeyCode.RightArrow) && IsGrounded()) 
//		{ 
//			rb.AddForce (transform.right*speed);
//			rb.AddForce (movement);

//		}
//
//		if (Input.GetKeyDown (KeyCode.LeftArrow) && IsGrounded()) 
//		{ 
//			rb.AddForce (-transform.right*speed);

//		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("yellowbolt")) {
			other.gameObject.SetActive (false);
			boltcount = boltcount + 1;
		}
//		if (other.gameObject.CompareTag ("speedforward")) {
//			other.gameObject.SetActive (false);
//
//		}

	}

}
