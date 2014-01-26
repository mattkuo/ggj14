using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{

		private int speed = 5;
		private bool isGrounded = true;
		private bool jump = false;
		public float jumpForce = 300f;
		public bool isGravityReversed = false;

		// Use this for initialization

		void Awake ()
		{
				if (gameObject.name == "black_player") {
						GameManager.blackPlayer = gameObject;
				} else {
						GameManager.whitePlayer = gameObject;
				}
		}

		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (!isGravityReversed) {

						if (Input.GetKey (KeyCode.RightArrow)) {
								transform.Translate (Vector3.right * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.LeftArrow)) {
								transform.Translate (Vector3.left * speed * Time.deltaTime);
						}

						if (Input.GetKey (KeyCode.UpArrow) && isGrounded == true) {
								jump = true;
								isGrounded = false;
				audio.Play();

					}
				} else {
						if (Input.GetKey (KeyCode.RightArrow)) {
								transform.Translate (Vector3.right * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.LeftArrow)) {
								transform.Translate (Vector3.left * speed * Time.deltaTime);
						}
			
						if (Input.GetKey (KeyCode.DownArrow) && isGrounded == true) {
								jump = true;
								isGrounded = false;
				audio.Play();
						}
				}
		}
		
		void FixedUpdate ()
		{
				if (jump == true) {

						if (!isGravityReversed) {
								rigidbody2D.AddForce (new Vector2 (0f, jumpForce));

						} else {
								rigidbody2D.AddForce (new Vector2 (0f, -1.0f * jumpForce));
						
						}
						jump = false;
				}
		}

		void OnCollisionEnter2D (Collision2D hit)
		{
				if (!isGravityReversed) {
						for (int i=0; i<hit.contacts.Length; i++) {
								if (hit.contacts [i].normal.y > 0) {
										isGrounded = true;
								}
						}
				} else {
						for (int i=0; i<hit.contacts.Length; i++) {
								if (hit.contacts [i].normal.y < 0) {
										isGrounded = true;
								}
						}
				}
		}
}
	
