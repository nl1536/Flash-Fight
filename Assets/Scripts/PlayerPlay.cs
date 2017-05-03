using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerPlay : MonoBehaviour {

    public KeyCode[] playerKeyCodes;
    public KeyCode chosenKeycode;
    float timeLeftUntilSwitch = 1f;

	// Use this for initialization
	void Start () {
        chosenKeycode = playerKeyCodes[Random.Range(0, playerKeyCodes.Length)];
    }

    // Update is called once per frame
    void Update() {

        // time left until keycode switches
        timeLeftUntilSwitch -= Time.deltaTime;

        // correct key pressed = point
        if (Input.GetKeyDown(chosenKeycode)) {
            Debug.Log("Correct key pressed");
        }

        // keycode switches every second
        if (timeLeftUntilSwitch <= 0) {
            Debug.Log("Switch");
            chosenKeycode = playerKeyCodes[Random.Range(0, playerKeyCodes.Length)];
            timeLeftUntilSwitch = 1f;
        }
	}
}
