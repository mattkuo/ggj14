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

	private int speed = 5;
	public bool right = false;
	public bool left = false;
	public bool up = false;
	public bool down = false;

	void CollisionEnter2D(Collision2D collide){
		transform.Translate(Vector3.right * 0.1f * Time.deltaTime);
		}

}