using UnityEngine;
using System.Collections;

public class ButtonAppear : MonoBehaviour
{



		public Sprite activated;
		public Sprite deactivated;
		private bool isActivated = false;
	public GameObject receiver;
		void Start ()
		{
		
		GetComponent<SpriteRenderer> ().sprite = deactivated;
		receiver.SetActive (false);
	}
	
		// Update is called once per frame
		void Update ()
		{
			if (isActivated) {
						receiver.SetActive (true);

				} else {
			receiver.SetActive(false);
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
