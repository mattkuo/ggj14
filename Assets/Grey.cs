using UnityEngine;
using System.Collections;

public class Grey : MonoBehaviour {

void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "white_player"){
			print("hit whiteplayers");
			GetComponent<BoxCollider2D>().enabled = false;
		}
		if(col.gameObject.name == "black_player"){
			print("hit blackplayers");
			GetComponent<BoxCollider2D>().enabled = true;
		}
}
}
