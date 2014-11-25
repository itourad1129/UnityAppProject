using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	
	Vector3 respawn;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0.5f + ScoreBoard.carSpeed, 0, 0);
		if(transform.position.x >= 41){
			respawn = GameObject.FindGameObjectWithTag ("CarRespawn").transform.position;
			transform.position = respawn; 
		}
	}


}
