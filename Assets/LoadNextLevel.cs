using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour
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
		whiteGoal = GameObject.Find ("WhiteGoal");
		blackGoal = GameObject.Find ("BlackGoal");
	}
	
		// Update is called once per frame
		void Update ()
		{
			
		}
		
//		void OnCollisionEnter2D (Collision2D collision)
//		{
//			if (blackGoal.collider2D.Equals(collision)) {
//			isBlackReady= true;		
//		}
//		if (whiteGoal.collider2D.Equals(collision)) {
//			isWhiteReady=true;
//		}
	//
	//			if (isBlackReady == true && isWhiteReady == true) {
	//					Application.LoadLevel ("tutorial2_jump");
	//			}
	//	}
}
