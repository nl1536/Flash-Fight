using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerRightScore : MonoBehaviour {

    public KeyCode addScore;
    public int playerRightScoreNumber;

    public AudioClip Slap;
    public AudioClip Grunt;

	// Use this for initialization
	void Start () {
        playerRightScoreNumber = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true) {

            addScore = GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode;
            if (addScore == KeyCode.None) addScore = GetComponent<PlayerPlay>().chosenKeycode;
            if (Input.GetKeyDown(addScore)) {
                playerRightScoreNumber++;
                GetComponent<AudioSource>().PlayOneShot(Slap);
                if (playerRightScoreNumber > GameObject.Find("PlayerLeft").GetComponent<PlayerLeftScore>().playerLeftScoreNumber) {
                    GetComponent<AudioSource>().PlayOneShot(Grunt);
                }
                GameObject.Find("PlayerRightText").GetComponent<Text>().text = playerRightScoreNumber.ToString();
                GameObject.Find("PlayerRightText").GetComponent<Transform>().position = new Vector3(GameObject.Find("PlayerRightText").GetComponent<Transform>().position.x,
                                                                                                   GameObject.Find("PlayerRightText").GetComponent<Transform>().position.y + 0.25f,
                                                                                                   GameObject.Find("PlayerRightText").GetComponent<Transform>().position.z);
            }
            // win and lose conditions
            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                if (playerRightScoreNumber <= GameObject.Find("PlayerLeft").GetComponent<PlayerLeftScore>().playerLeftScoreNumber) {
                    GetComponent<Animator>().SetTrigger("Lose");
                }
                if (playerRightScoreNumber > GameObject.Find("PlayerLeft").GetComponent<PlayerLeftScore>().playerLeftScoreNumber) {
                    GetComponent<Animator>().SetTrigger("Win");
                }
            }
        }
    }
}
