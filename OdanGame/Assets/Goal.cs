using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.tag == "Player") {
			Debug.Log("Goal!"); 
			ScoreBoard.totalScore = ScoreBoard.totalScore + 100;
			ScoreBoard.carSpeed = ScoreBoard.carSpeed + 0.1f;

		} 
	}
}
