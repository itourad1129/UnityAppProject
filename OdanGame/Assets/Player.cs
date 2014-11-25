using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 6.0f;
	Vector3 respawn;
	Vector3 GameOver;
	static public int totalScore;
	Vector3 goal;
	void Start()
	{
	
	}
	public void Update()
	{
		transform.position += new Vector3(0, 0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
		if (ScoreBoard.life <= 0){
			Debug.Log("end");
			GameOver = GameObject.FindGameObjectWithTag ("GameOver").transform.position;
			transform.position = GameOver; 
		}
	}

	void OnTriggerEnter(Collider goal)
	{
		if (goal.gameObject.tag == "Goal") {
			respawn = GameObject.FindGameObjectWithTag ("PlayerRespawn").transform.position;
			transform.position = respawn;
		}
		if (goal.gameObject.tag == "Car") {
			ScoreBoard.life = ScoreBoard.life - 1;
			respawn = GameObject.FindGameObjectWithTag ("PlayerRespawn").transform.position;
			transform.position = respawn;
		}
		if (goal.gameObject.tag == "Car2") {
			ScoreBoard.life = ScoreBoard.life - 1;
			respawn = GameObject.FindGameObjectWithTag ("PlayerRespawn").transform.position;
			transform.position = respawn;
		}
	}
	
}
