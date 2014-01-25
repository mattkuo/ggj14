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
			isBlackReady= true;	
			print("black hit");
		}
		if (collision.gameObject.name == "black_player") {
			isWhiteReady=true;
			print ("white hit");
		}
		
		if (isBlackReady == true && isWhiteReady == true) {
			print ("both true");
			if(Application.loadedLevelName == "tutorial1_straight")
			Application.LoadLevel ("tutorial2_jump");
			if(Application.loadedLevelName == "tutorial2_jump")
			Application.LoadLevel ("tutorial3_spikes");
			if(Application.loadedLevelName == "tutorial3_spikes")
			Application.LoadLevel ("tutorial4_platform");


			isWhiteReady=false;
			isBlackReady=false;
		}
	}
	
}
