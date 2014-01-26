using UnityEngine;
using System.Collections;

public class ButtonAppear : MonoBehaviour
{



		public Sprite activated;
		public Sprite deactivated;
		private bool isActivated = false;
	public GameObject receiver;
	public GameObject receiver1;
	public GameObject receiver2;


	public GameObject turnoff;
	public GameObject turnoff1;
	public GameObject turnoff2;

		void Start ()
		{
		
		GetComponent<SpriteRenderer> ().sprite = deactivated;
		receiver.SetActive (false);
		receiver1.SetActive (false);
		receiver2.SetActive (false);



	}
	
		// Update is called once per frame
		void Update ()
		{
			if (isActivated) {
			receiver.SetActive (true);
			receiver1.SetActive (true);
			receiver2.SetActive (true);




			turnoff.SetActive (false);
			turnoff1.SetActive (false);
			turnoff2.SetActive (false);



				} else {
			receiver.SetActive (false);
			receiver1.SetActive (false);
			receiver2.SetActive (false);




			turnoff.SetActive (true);
			turnoff1.SetActive (true);
			turnoff2.SetActive (true);

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
