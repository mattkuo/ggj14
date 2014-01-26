using UnityEngine;
using System.Collections;

public class Mirrory : MonoBehaviour
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
		if (Target.renderer.bounds.center.x <= renderer.bounds.max.x && Target.renderer.bounds.center.x>= renderer.bounds.min.x) {
				print ("true");
			reflect =true;
			
		}
		
		if (Target.renderer.bounds.center.x < renderer.bounds.min.x||Target.renderer.bounds.center.x > renderer.bounds.max.x) {
			print("false");
			reflect =false;
		}
		

		if (reflect == true) {
			float ypos = Target.renderer.bounds.center.y-renderer.bounds.center.y;
			reflection.transform.position = new Vector3(Target.transform.position.x,renderer.bounds.center.y-ypos,0);
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

