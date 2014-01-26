using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour
{
	public Transform endObj;
	public Transform target;
	public bool teleport = false;
	// Use this for initialization
		void Start ()
		{
		teleport = false;

		}
	
		// Update is called once per frame
		void Update ()
		{
		if (teleport == true) {
			float ypos=			endObj.position.y+ 5;
			target.position = new Vector3(endObj.position.x, ypos, 0);
			teleport=false;

		}
		}

	void OnCollisionEnter2D(Collision2D col){

			teleport = true;

				

	}

}

