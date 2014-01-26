using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{

		private int speed = 5;
		private bool isGrounded = true;
		private bool jump = false;
		public float jumpForce = 300f;

		// Use this for initialization

		void Awake ()
		{
				print ("Load player");
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
		}

		void FixedUpdate ()
		{
				if (jump == true) {
						print ("JUMP");
						rigidbody2D.AddForce (new Vector2 (0f, jumpForce));
						jump = false;
				}
		}

		void OnCollisionEnter2D (Collision2D hit)
		{
				print (hit.gameObject.name);
				for (int i=0; i<hit.contacts.Length; i++) {
						if (hit.contacts [i].normal.y > 0) {
								print ("Hit blackground");
								isGrounded = true;
						}
				}
		}
}
