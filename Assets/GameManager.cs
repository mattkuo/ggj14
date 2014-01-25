using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static bool isSelectedBlack;
	private GameObject whitePlayer;
	private GameObject blackPlayer;
	public static bool isBlackReady;
	public static bool isWhiteReady;
	private GameObject whiteGoal;
	private GameObject blackGoal;

	// Use this for initialization
	void Start () {
		isSelectedBlack = true;
		whitePlayer = GameObject.Find ("white_player");
		blackPlayer = GameObject.Find ("black_player");
		whitePlayer.GetComponent<CharacterMove> ().enabled = false;
		isBlackReady = false;
		isWhiteReady = false;
		whiteGoal = GameObject.Find ("WhiteGoal");
		blackGoal = GameObject.Find ("BlackGoal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel(Application.loadedLevelName);		
		
		}
		if (Input.GetKeyDown (KeyCode.Tab)) {
			isSelectedBlack = !isSelectedBlack;
			blackPlayer.GetComponent<CharacterMove> ().enabled = isSelectedBlack;
			whitePlayer.GetComponent<CharacterMove> ().enabled = !isSelectedBlack;
		}

		if (isWhiteReady == true) {
			Application.LoadLevel ("tutorial2_jump");
				}
	}

	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.Equals (whiteGoal)) {
			isWhiteReady=true;
				}
//		if (collision.gameObject.Equals (blackGoal)) {
//			isBlackReady=true;		
//		}
	}
}
