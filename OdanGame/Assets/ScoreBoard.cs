using UnityEngine;
using System.Collections;

public class ScoreBoard : MonoBehaviour {
	static public int totalScore;
	static public int life;
	static public float carSpeed;
	
	void Start () {
		life = 3;
	}
	
	void OnGUI () {
		GUI.Label(new Rect(40,20,120,20),"Score:"+totalScore);
		GUI.Label(new Rect(40,35,120,20),"LIFE:"+life);
	}       
	
}