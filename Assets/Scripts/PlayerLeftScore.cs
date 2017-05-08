using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLeftScore : MonoBehaviour {

    public KeyCode addScore;
    public int playerLeftScoreNumber;

    public AudioClip Slap;
    public AudioClip Grunt;

	// Use this for initialization
	void Start () {
        playerLeftScoreNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Countdown").GetComponent<Countdown>().gamePlay == true) {

            addScore = GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode;
            if (addScore == KeyCode.None) addScore = GetComponent<PlayerPlay>().chosenKeycode;
            if (Input.GetKeyDown(addScore)) {
                playerLeftScoreNumber++;
                GetComponent<AudioSource>().PlayOneShot(Slap);
                if (playerLeftScoreNumber > GameObject.Find("PlayerRight").GetComponent<PlayerRightScore>().playerRightScoreNumber) {
                    GetComponent<AudioSource>().PlayOneShot(Grunt);
                }
                GameObject.Find("PlayerLeftText").GetComponent<Text>().text = playerLeftScoreNumber.ToString();
                GameObject.Find("PlayerLeftText").GetComponent<Transform>().position = new Vector3(GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.x,
                                                                                                   GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.y + 0.25f,
                                                                                                   GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.z);
            }
            // win and lose conditions
            if (GameObject.Find("Timer").GetComponent<Timer>().timeLeft <= 0) {
                if (playerLeftScoreNumber <= GameObject.Find("PlayerRight").GetComponent<PlayerRightScore>().playerRightScoreNumber) {
                    GetComponent<Animator>().SetTrigger("Lose");
                }
                if (playerLeftScoreNumber > GameObject.Find("PlayerRight").GetComponent<PlayerRightScore>().playerRightScoreNumber) {
                    GetComponent<Animator>().SetTrigger("Win");
                    GameObject.Find("WinnerLeft").GetComponent<TargetJoint2D>().target =
                        new Vector2(GameObject.Find("WinnerLeft").GetComponent<TargetJoint2D>().target.x, -4f);
                }
            }
        }
    }
}
