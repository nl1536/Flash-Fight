using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerPlay : MonoBehaviour {

    public KeyCode[] playerKeyCodes;
    public KeyCode chosenKeycode;
    float timeLeftUntilSwitch;

	// Use this for initialization
	void Start () {
        timeLeftUntilSwitch = 0f;
        GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update() {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true) {

        // time left until keycode switches
        timeLeftUntilSwitch -= Time.deltaTime;

        // correct key pressed = point
        if (Input.GetKey(chosenKeycode)) {
            Debug.Log("Correct key pressed");
            GetComponent<Animator>().SetBool("Fight", true);
        }
        else {
            GetComponent<Animator>().SetBool("Fight", false);
        }

            // keycode switches every second
            if (timeLeftUntilSwitch <= 0) {
                Debug.Log("Switch");
                chosenKeycode = playerKeyCodes[Random.Range(0, playerKeyCodes.Length)];
                timeLeftUntilSwitch = 1f;
            }
        }
    }
}
