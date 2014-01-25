using UnityEngine;
using System.Collections;

public class ForceDirection : MonoBehaviour {
	
	private int speed = 5;
	public bool right = false;
	public bool left = false;
	public bool up = false;
	public bool down = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (right) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if (left) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		
		if (up) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		if (down) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
	}
	
	
}

