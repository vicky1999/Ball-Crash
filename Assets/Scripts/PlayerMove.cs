using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
	public float move=0.2f;
	public GameObject Player;
    void Start()
    {

    }

	void Update() {
		float axis=CrossPlatformInputManager.GetAxis("Horizontal");
		//Debug.Log(Screen.width);
		//Debug.Log(this.transform.position.x);
		Player.transform.position = new Vector3(transform.position.x,transform.position.y,0f);
		
		Player.transform.position = new Vector2(Player.transform.position.x+(axis*move),Player.transform.position.y);
		//Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f)));
	}

	public void OnMoveRight() {
		Player.transform.position = new Vector2(Player.transform.position.x+(move%3.2f),Player.transform.position.y);
	}


	public void OnMoveLeft() {
		Player.transform.position = new Vector2(Player.transform.position.x+(-(move%3.2f)),Player.transform.position.y);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="Obstacle") {
			Debug.Log("Hit..!, Lose Health...");
			SceneManager.LoadScene("End");
		}
	}
}
