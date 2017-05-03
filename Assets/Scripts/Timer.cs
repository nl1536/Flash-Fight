using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    float timeLeft;
    int timeLeftDisplay;

	// Use this for initialization
	void Start () {
        timeLeft = 10;
	}
	
	// Update is called once per frame
	void Update () {
        // display countdown
        timeLeft -= Time.deltaTime;
        GetComponent<Text>().text = timeLeftDisplay.ToString();

        // countdown
        if (timeLeft > 9 && timeLeft <= 10) {
            timeLeftDisplay = 10;
        }
        if (timeLeft > 8 && timeLeft <= 9) {
            timeLeftDisplay = 9;
        }
        if (timeLeft > 7 && timeLeft <= 8) {
            timeLeftDisplay = 8;
        }
        if (timeLeft > 6 && timeLeft <= 7) {
            timeLeftDisplay = 7;
        }
        if (timeLeft > 5 && timeLeft <= 6) {
            timeLeftDisplay = 6;
        }
        if (timeLeft > 4 && timeLeft <= 5) {
            timeLeftDisplay = 5;
        }
        if (timeLeft > 3 && timeLeft <= 4) {
            timeLeftDisplay = 4;
        }
        if (timeLeft > 2 && timeLeft <= 3) {
            timeLeftDisplay = 3;
        }
        if (timeLeft > 1 && timeLeft <= 2) {
            timeLeftDisplay = 2;
        }
        if (timeLeft > 0 && timeLeft <= 1) {
            timeLeftDisplay = 1;
        }
        if (timeLeft <= 0) {
            timeLeftDisplay = 0;
        }
	}
}
