using UnityEngine;
using System.Collections;

public class ButtonGravity : MonoBehaviour
{
		private bool isGrounded = true;
		private bool revjump = false;
		public int gravNum = 1;
		public int revGravNum = -1;

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

		void OnCollisionEnter2D (Collision2D collision)
		{
				isActivated = true;
				GetComponent<SpriteRenderer> ().sprite = activated;
				player.gravityScale = revGravNum;
				player.GetComponent<CharacterMove> ().isGravityReversed = true;
	
		}

		void OnCollisionExit2D (Collision2D collisionInfo)
		{
				isActivated = false;
				GetComponent<SpriteRenderer> ().sprite = deactivated;
				player.gravityScale = gravNum;
				player.GetComponent<CharacterMove> ().isGravityReversed = false;
		}
}
