using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static bool isSelectedBlack;
	public static GameObject whitePlayer;
	public static GameObject blackPlayer;
	
	void Awake() {
		isSelectedBlack = true;
		
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("GameManager started");
//		Physics2D.IgnoreLayerCollision (8, 11, true);
//		Physics2D.IgnoreLayerCollision (9, 10, true);
		whitePlayer.GetComponent<CharacterMove> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			Debug.Log("Tab");
			isSelectedBlack = !isSelectedBlack;
			blackPlayer.GetComponent<CharacterMove> ().enabled = isSelectedBlack;
			whitePlayer.GetComponent<CharacterMove> ().enabled = !isSelectedBlack;
		}
	}
}
