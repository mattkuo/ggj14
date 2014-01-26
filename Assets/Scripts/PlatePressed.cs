using UnityEngine;
using System.Collections;

public class PlatePressed : MonoBehaviour
{
		public Sprite activated;
		public Sprite deactivated;
		private bool isActivated = false;
		public Transform DestinationSpot;

		public float Speed;
		public Sprite receiver;

		// Use this for initialization
		void Start ()
		{
				GetComponent<SpriteRenderer> ().sprite = deactivated;
		}
	
		// Update is called once per frame
		void Update ()
		{
			
		}
		void moveReceiver(){
		transform.Translate ();
		}


		void OnCollisionEnter2D (Collision2D collision)
		{
			SendMessage ("moveReceiver");
//			SendMessage ("PlatePressed", true);
				if (collision.gameObject.name == "black_player") {
						isActivated = true;
						GetComponent<SpriteRenderer> ().sprite = activated;
				}
		}

		void OnCollisionExit2D (Collision2D collisionInfo)
		{
//				SendMessage ("PlatePressed", false);
				isActivated = false;
				GetComponent<SpriteRenderer> ().sprite = deactivated;
		}
}
