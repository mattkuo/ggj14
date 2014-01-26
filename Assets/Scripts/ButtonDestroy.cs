using UnityEngine;
using System.Collections;

public class ButtonDestroy : MonoBehaviour
{
		public Sprite activated;
		public Sprite deactivated;
		private bool isActivated = false;
		//public Transform DestinationSpot;

		//public float Speed;
		public GameObject receiver;

		// Use this for initialization
		void Start ()
		{
				GetComponent<SpriteRenderer> ().sprite = deactivated;
		//receiver = GameObject.Find ("white_wall");
		}
	
		// Update is called once per frame
		void Update ()
		{
			if (isActivated) {
				
			Destroy(receiver);
		}
		}

		void OnCollisionEnter2D (Collision2D collision)
		{
			
			
						isActivated = true;

						GetComponent<SpriteRenderer> ().sprite = activated;
				
		}

		void OnCollisionExit2D (Collision2D collisionInfo)
		{
				GetComponent<SpriteRenderer> ().sprite = deactivated;
		}
}
