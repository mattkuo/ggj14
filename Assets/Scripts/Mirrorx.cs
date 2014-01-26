using UnityEngine;
using System.Collections;

public class Mirrorx : MonoBehaviour
{
	public GameObject Pivot;
	public GameObject Target;
	public bool reflect;
	private GameObject reflection;

		// Use this for initialization
		void Start ()
		{
		reflect = false;
		reflection = Instantiate (Target)as GameObject;

		reflection.SetActive (false);
	}
	
		// Update is called once per frame
		void Update ()
		{
		if (Target.renderer.bounds.center.y <= renderer.bounds.max.y&& Target.renderer.bounds.center.y>= renderer.bounds.min.y) {
					//	print ("true");
			reflect =true;

		}

		if (Target.renderer.bounds.center.y < renderer.bounds.min.y||Target.renderer.bounds.center.y > renderer.bounds.max.y) {
		
			reflect =false;
		}
			
	
		if (reflect == true) {
			float xpos = Target.renderer.bounds.center.x-renderer.bounds.center.x;
			reflection.transform.position = new Vector3(renderer.bounds.center.x-xpos, Target.transform.position.y,0);
			reflection.SetActive(true);


				}

		if (reflect == false){
			reflection.SetActive(false);
		}
	
	}
//			if (Mirror.renderer.bounds.max.x)
//		if (Target.renderer.bounds.center.y <= renderer.bounds.max.y && Target.renderer.bounds.center.y >= renderer.bounds.min.y) {
//						print ("true");
//						reflect = true;
///				} else {
//			reflect = false;
//			print ("false");
//				}

	
}

