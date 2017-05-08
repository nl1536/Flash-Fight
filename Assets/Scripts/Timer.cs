using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeLeft;
    public int timeLeftDisplay;
    
    public AudioClip EndTime;
    public AudioClip StartTime;

    public Color Green;
    public Color Yellow;
    public Color Red;

	// Use this for initialization
	void Start () {
        timeLeft = 13;
        GetComponent<Text>().fontSize = 60;
	}
	
	// Update is called once per frame
	void Update () {

        // display countdown
        timeLeft -= Time.deltaTime;
        GetComponent<Text>().text = timeLeftDisplay.ToString();

        // countdown
        if (timeLeft > 9 && timeLeft <= 10) {
            timeLeftDisplay = 10;
            GetComponent<Text>().color = Green;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 10 && timeLeft > 9.97) {
                GetComponent<AudioSource>().PlayOneShot(StartTime);
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 8 && timeLeft <= 9) {
            timeLeftDisplay = 9;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 8.97 && timeLeft > 8.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 7 && timeLeft <= 8) {
            timeLeftDisplay = 8;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 7.97 && timeLeft > 7.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 6 && timeLeft <= 7) {
            timeLeftDisplay = 7;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 6.97 && timeLeft > 6.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 5 && timeLeft <= 6) {
            timeLeftDisplay = 6;
            GetComponent<Text>().color = Yellow;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 5.97 && timeLeft > 5.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 4 && timeLeft <= 5) {
            timeLeftDisplay = 5;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 4.97 && timeLeft > 4.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 3 && timeLeft <= 4) {
            timeLeftDisplay = 4;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 3.97 && timeLeft > 3.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 2 && timeLeft <= 3) {
            timeLeftDisplay = 3;
            GetComponent<Text>().color = Red;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 2.97 && timeLeft > 2.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 1 && timeLeft <= 2) {
            timeLeftDisplay = 2;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 1.97 && timeLeft > 1.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft > 0 && timeLeft <= 1) {
            timeLeftDisplay = 1;
            GetComponent<Text>().fontSize -= 1;
            if (timeLeft <= 0.97 && timeLeft > 0.94) {
                GetComponent<Text>().fontSize = 60;
            }
        }
        if (timeLeft <= 0) {
            timeLeftDisplay = 0;
            GetComponent<Text>().fontSize = 60;
            GameObject.Find("NewRoundButton").GetComponent<TargetJoint2D>().target =
                new Vector2(GameObject.Find("NewRoundButton").GetComponent<TargetJoint2D>().target.x, 0f);
            GameObject.Find("TitleButton").GetComponent<TargetJoint2D>().target =
                new Vector2(GameObject.Find("TitleButton").GetComponent<TargetJoint2D>().target.x, -1.5f);
        if (timeLeft <= 0 && timeLeft > -.03) {
            GetComponent<AudioSource>().PlayOneShot(EndTime);
            }
        }
    }
}
