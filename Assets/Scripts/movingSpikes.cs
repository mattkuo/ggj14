using UnityEngine;
using System.Collections;

public class movingSpikes : MonoBehaviour {

	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	public  bool toOrigin = false;
	
	void FixedUpdate()
	{
		if(transform.position == DestinationSpot.position)
		{
			toOrigin = true;
		}
		if(transform.position == OriginSpot.position)
		{
			toOrigin = false;
		}
		
		if(toOrigin)
		{
			transform.position = OriginSpot.position;
		}
		else
		{
			// If Switch is false, it tells the platform to move to the destination.
			transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed);
		}
	}
}
