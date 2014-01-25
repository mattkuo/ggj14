using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * 3 * Time.deltaTime);
		}
	}
}
