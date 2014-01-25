using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		Application.LoadLevel(Application.loadedLevelName);	
		}
}
