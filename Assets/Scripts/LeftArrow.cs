using UnityEngine;
using System.Collections;

public class LeftArrow : MonoBehaviour {

    public bool moveRight;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == false) {
            GetComponent<SpriteRenderer>().enabled = false;
        }

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true) {
            GetComponent<SpriteRenderer>().enabled = true;

            if (GetComponent<Transform>().position.x <= -3.3f) {
            moveRight = true;
        }
        if (GetComponent<Transform>().position.x >= -3.0f) {
            moveRight = false;
        }

        if (moveRight == true) {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + 0.01f,
                                                             GetComponent<Transform>().position.y,
                                                             GetComponent<Transform>().position.z);
        }
        else {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 0.01f,
                                                             GetComponent<Transform>().position.y,
                                                             GetComponent<Transform>().position.z);
        }

            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
	}
}
