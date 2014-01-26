using UnityEngine;
using System.Collections;

public class ButtonGravity : MonoBehaviour
{
	private bool isGrounded = true;
	private bool revjump = false;
	public float revjumpForce = -300f;



		public Sprite activated;
		public Sprite deactivated;
		private bool isActivated = false;
		// Use this for initialization
		public Rigidbody2D player;
	private bool rev = false;
		void Start ()
		{
				GetComponent<SpriteRenderer> ().sprite = deactivated;
		//receiver = GameObject.Find ("white_wall");
		}
	
		// Update is called once per frame
		void Update ()
		{
			if (isActivated) {
						rev = true;
						player.gravityScale = -1;
					} else {
			rev = false;
			player.gravityScale=9.8f;
				}
			

		}
		




		void OnCollisionEnter2D (Collision2D collision)
		{
			
						isActivated = true;
						GetComponent<SpriteRenderer> ().sprite = activated;
	
		}

		void OnCollisionExit2D (Collision2D collisionInfo)
		{
	
		isActivated = false;
		GetComponent<SpriteRenderer> ().sprite = deactivated;
		}
}
