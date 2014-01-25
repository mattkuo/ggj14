using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	private int speed = 5;
	private int jumpSpeed = 50;
	private bool isGrounded = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
	}

//	void FixedUpdate () {
//		if (isGrounded && Input.GetKey (KeyCode.UpArrow)) {
//			rigidbody2D.AddForce(Vector3.up * jumpSpeed);
//			isGrounded = false;
//		}
//	}
//
//	void OnCollisionEnter () {
//		isGrounded = true;
//	}

}
