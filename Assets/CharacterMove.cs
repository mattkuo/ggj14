using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	private int speed = 5;
	private bool isGrounded = true;
	public bool jump = false;
	public float jumpForce = 300f;
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

		if (Input.GetKey (KeyCode.UpArrow) && isGrounded == true) {
			jump = true;
			isGrounded = false;
		}
	}

	void FixedUpdate () {
		if (jump == true) {
			rigidbody2D.AddForce (new Vector2 (0f, jumpForce));
			jump = false;
		}
	}

	void OnCollisionEnter2D (Collision2D hit) {
		isGrounded = true;
	}

}
