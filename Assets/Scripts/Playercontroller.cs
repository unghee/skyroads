using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

	public float speed;
	private float distToGround;
	private Rigidbody rb;
	private Collider collider;

	void Start()
	{

		rb = GetComponent<Rigidbody> ();
		distToGround = collider.bounds.extents.y;
	}

	bool IsGrounded(){
//		return Physics.Raycast(transform.position, -Vector3.up,  0.1);
		return Physics.Raycast(transform.position, -Vector3.up,  distToGround+ 1);
	}

	void FixedUpdate() 
	{
//		float moveHorizontal = Input.GetAxis("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


		Vector3 fixedmovement = new Vector3 (0, 0.0f, 1);
		Vector3 jumpmovement = new Vector3 (0, 5, 0);

//		rb.AddForce (movement*speed);

		rb.AddForce (fixedmovement * speed);

		print (IsGrounded ());

		if (Input.GetKeyDown (KeyCode.Space) && IsGrounded()) 
		{ 
			rb.AddForce (jumpmovement, ForceMode.Impulse);

		}

	}

}
