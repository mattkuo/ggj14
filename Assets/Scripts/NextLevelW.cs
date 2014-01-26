using UnityEngine;
using System.Collections;

public class NextLevelW : MonoBehaviour
{
	public static bool isBlackReady;
	public static bool isWhiteReady;
	private GameObject whiteGoal;
	private GameObject blackGoal;
	// Use this for initialization
	void Start ()
	{
		isBlackReady = false;
		isWhiteReady = false;
		whiteGoal = GameObject.Find ("end_platform");
		blackGoal = GameObject.Find ("end_platform2");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		print ("got into here");
		if (collision.gameObject.name == "white_player") {
			isWhiteReady= true;	
			print("black hit");
		}
		if (collision.gameObject.name == "black_player") {
			isBlackReady=true;
			print ("white hit");
		}
		
		if (isBlackReady == true && isWhiteReady == true) {
			print ("both true");
			audio.Play();
			if(Application.loadedLevelName == "tutorial1_straight")
			Application.LoadLevel ("tutorial2_jump");

			if(Application.loadedLevelName == "tutorial2_jump")
			Application.LoadLevel ("tutorial3_spikes");

			if(Application.loadedLevelName == "tutorial3_spikes")
			Application.LoadLevel ("tutorial4_platform");

			if(Application.loadedLevelName == "tutorial4_platform")
				Application.LoadLevel ("tutorial5_button");

			if(Application.loadedLevelName == "tutorial5_button")
				Application.LoadLevel ("tutorial6_teleport");

			if(Application.loadedLevelName == "tutorial6_teleport")
				Application.LoadLevel("seperateentity");
			
			if(Application.loadedLevelName == "seperateentity")
				Application.LoadLevel ("level_move_spikes");

			if(Application.loadedLevelName == "level_move_spikes")
				Application.LoadLevel ("diagonal Level");

			if(Application.loadedLevelName == "diagonal Level")
				Application.LoadLevel ("hardlevel1");

			if(Application.loadedLevelName == "hardlevel1")
				Application.LoadLevel ("timelyDeath");

			if(Application.loadedLevelName == "timelyDeath")
				Application.LoadLevel ("level_teleport");








			isWhiteReady=false;
			isBlackReady=false;
		}
	}
	void OnCollisionExit2D(Collision2D collision){
		if (collision.gameObject.name == "black_player") {
			isBlackReady=false;
		
		}
		if (collision.gameObject.name == "white_player") {
			isWhiteReady=false;
		}

	}
	
}
