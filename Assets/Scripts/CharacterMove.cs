using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	private int speed = 5;
	private bool isGrounded = true;
	private bool jump = false;
	public float jumpForce = 300f;
	public static bool isBlackReady = false;
	public static bool isWhiteReady = false;
	private GameObject whiteGoal;
	private GameObject blackGoal;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKey (KeyCode.RightArrow)) {
					transform.Translate (Vector3.right * speed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
					transform.Translate (Vector3.left * speed * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.UpArrow) && isGrounded == true) {
					jump = true;
					isGrounded = false;
			}
		if (isWhiteReady == true && isBlackReady ==true) {
			Application.LoadLevel ("tutorial2_jump");
		}
	}

	void FixedUpdate () {
		if (jump == true) {
			print ("JUMP");
			rigidbody2D.AddForce (new Vector2 (0f, jumpForce));
			jump = false;
		}
	}

	void OnCollisionEnter2D (Collision2D hit) {
		//if(hit.gameObject.name == "black_ground")
		isGrounded = true;
	}

}
