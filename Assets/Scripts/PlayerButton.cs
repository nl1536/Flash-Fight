using UnityEngine;
using System.Collections;

public class PlayerButton : MonoBehaviour {

    public Sprite Q;
    public Sprite W;
    public Sprite E;
    public Sprite R;
    public Sprite A;
    public Sprite S;
    public Sprite D;
    public Sprite F;
    public Sprite Z;
    public Sprite X;
    public Sprite C;
    public Sprite V;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == false) {
            GetComponent<SpriteRenderer>().enabled = false;
        }

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true) {
            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft > 0f) {
                GetComponent<SpriteRenderer>().enabled = true;
            }

            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
            GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[0]) {
                GetComponent<SpriteRenderer>().sprite = Q;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[1]) {
                GetComponent<SpriteRenderer>().sprite = W;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[2]) {
                GetComponent<SpriteRenderer>().sprite = E;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[3]) {
                GetComponent<SpriteRenderer>().sprite = R;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[4]) {
                GetComponent<SpriteRenderer>().sprite = A;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[5]) {
                GetComponent<SpriteRenderer>().sprite = S;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[6]) {
                GetComponent<SpriteRenderer>().sprite = D;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[7]) {
                GetComponent<SpriteRenderer>().sprite = F;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[8]) {
                GetComponent<SpriteRenderer>().sprite = Z;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[9]) {
                GetComponent<SpriteRenderer>().sprite = X;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[10]) {
                GetComponent<SpriteRenderer>().sprite = C;
            }
            if (GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().playerKeyCodes[11]) {
                GetComponent<SpriteRenderer>().sprite = V;
            }

            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
