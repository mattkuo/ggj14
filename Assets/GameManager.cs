using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static bool isSelectedBlack;
	private GameObject whitePlayer;
	private GameObject blackPlayer;

	// Use this for initialization
	void Start () {
		isSelectedBlack = true;
		whitePlayer = GameObject.Find ("white_player");
		blackPlayer = GameObject.Find ("black_player");
		whitePlayer.GetComponent<CharacterMove> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			isSelectedBlack = !isSelectedBlack;
			blackPlayer.GetComponent<CharacterMove> ().enabled = isSelectedBlack;
			whitePlayer.GetComponent<CharacterMove> ().enabled = !isSelectedBlack;
		}
	}
}
