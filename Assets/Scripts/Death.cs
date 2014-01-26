using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		audio.Play();

		Application.LoadLevel(Application.loadedLevelName);	

		}
}
