using UnityEngine;
using System.Collections;

public class RightArrow : MonoBehaviour {

    public bool moveLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == false) {
            GetComponent<SpriteRenderer>().enabled = false;
        }

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true)
        {
            GetComponent<SpriteRenderer>().enabled = true;

            if (GetComponent<Transform>().position.x <= 3.1f) {
            moveLeft = false;
        }
        if (GetComponent<Transform>().position.x >= 3.4f) {
            moveLeft = true;
        }

        if (moveLeft == true) {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 0.01f,
                                                             GetComponent<Transform>().position.y,
                                                             GetComponent<Transform>().position.z);
        }
        else {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + 0.01f,
                                                             GetComponent<Transform>().position.y,
                                                             GetComponent<Transform>().position.z);
        }

            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
