using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerRightScore : MonoBehaviour {

    public KeyCode addScore;
    public int playerRightScoreNumber;

	// Use this for initialization
	void Start () {
        playerRightScoreNumber = 0;
    }
	
	// Update is called once per frame
	void Update () {
        addScore = GameObject.Find("PlayerRight").GetComponent<PlayerPlay>().chosenKeycode;
        if (addScore == KeyCode.None) addScore = GetComponent<PlayerPlay>().chosenKeycode;
        if (Input.GetKeyDown(addScore)) {
            playerRightScoreNumber++;
            GameObject.Find("PlayerRightText").GetComponent<Text>().text = playerRightScoreNumber.ToString();
            GameObject.Find("PlayerRightText").GetComponent<Transform>().position = new Vector3(GameObject.Find("PlayerRightText").GetComponent<Transform>().position.x,
                                                                                               GameObject.Find("PlayerRightText").GetComponent<Transform>().position.y + 10f,
                                                                                               GameObject.Find("PlayerRightText").GetComponent<Transform>().position.z);
        }
    }
}
