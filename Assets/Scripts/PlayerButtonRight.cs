using UnityEngine;
using System.Collections;

public class PlayerButtonRight : MonoBehaviour {

    public Sprite P;
    public Sprite O;
    public Sprite I;
    public Sprite U;
    public Sprite L;
    public Sprite K;
    public Sprite J;
    public Sprite H;
    public Sprite G;
    public Sprite M;
    public Sprite N;
    public Sprite B;

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

            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
            GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[0]) {
                GetComponent<SpriteRenderer>().sprite = P;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[1]) {
                GetComponent<SpriteRenderer>().sprite = O;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[2]) {
                GetComponent<SpriteRenderer>().sprite = I;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[3]) {
                GetComponent<SpriteRenderer>().sprite = U;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[4]) {
                GetComponent<SpriteRenderer>().sprite = L;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[5]) {
                GetComponent<SpriteRenderer>().sprite = K;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[6]) {
                GetComponent<SpriteRenderer>().sprite = J;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[7]) {
                GetComponent<SpriteRenderer>().sprite = H;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[8]) {
                GetComponent<SpriteRenderer>().sprite = G;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[9]) {
                GetComponent<SpriteRenderer>().sprite = M;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[10]) {
                GetComponent<SpriteRenderer>().sprite = N;
            }
            if (GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode ==
                GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().playerKeyCodes[11]) {
                GetComponent<SpriteRenderer>().sprite = B;
            }

            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
