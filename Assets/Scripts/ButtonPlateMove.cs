using UnityEngine;
using System.Collections;

public class ButtonPlateMove : MonoBehaviour {

	public Transform black_platform;
	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	private bool toOrigin = false;
	private bool isActivated = false;
	public Sprite activated;
	public Sprite deactivated;
	// Update is called once per frame
	void Update ()
	{
		if (isActivated) {
			
			plateMovement();
		}
	}



	void plateMovement(){

				if (black_platform.position == DestinationSpot.position) {
						toOrigin = true;
				}
				if (black_platform.position == OriginSpot.position) {
						toOrigin = false;
				}
		
				if (toOrigin) {
						black_platform.position = Vector3.MoveTowards (black_platform.position, OriginSpot.position, Speed);
				} else {
						// If Switch is false, it tells the platform to move to the destination.
						black_platform.position = Vector3.MoveTowards (black_platform.position, DestinationSpot.position, Speed);
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
