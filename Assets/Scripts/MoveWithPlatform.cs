using UnityEngine;
using System.Collections;

/**
    * Helps keeping charactercontroller entities nicely on the platform
    * Needs a Collider set as trigger in the gameobject this script is added to
    * works best if collider is bit smaller as platform but extends quite a lot
    * (say .5m or so) above the platform, As the platform possibly already has
    * a normal collider the easiest way is to add a GameObject to the platform,
    * give it a trigger collider and add this script. The yOffset is the vertical
    * offset the character should have above the platform (a good value to start
    * with is half the y value of the Collider size).
    */
public class MoveWithPlatform : MonoBehaviour {

	public Transform black_platform;
	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	public bool toOrigin = false;

void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name == "black_platform" || collision.gameObject.name == "white_platform"){
			movement();
		}
	}


	void movement()
	{
		if(black_platform.transform.position == DestinationSpot.position)
		{
			toOrigin = true;
		}
		if(black_platform.transform.position == OriginSpot.position)
		{
			toOrigin = false;
		}
		
		if(toOrigin)
		{
			transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position*5, Speed);
		}
		else
		{
			// If Switch is false, it tells the platform to move to the destination.
			transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position*5, Speed);
		}
	}
}