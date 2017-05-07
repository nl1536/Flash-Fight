using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLeftScore : MonoBehaviour {

    public KeyCode addScore;
    public int playerLeftScoreNumber;

	// Use this for initialization
	void Start () {
        playerLeftScoreNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
        addScore = GameObject.Find("PlayerLeft").GetComponent<PlayerPlay>().chosenKeycode;
        if (addScore == KeyCode.None) addScore = GetComponent<PlayerPlay>().chosenKeycode;
        if (Input.GetKeyDown(addScore)) {
            playerLeftScoreNumber++;
            GameObject.Find("PlayerLeftText").GetComponent<Text>().text = playerLeftScoreNumber.ToString();
            GameObject.Find("PlayerLeftText").GetComponent<Transform>().position = new Vector3(GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.x,
                                                                                               GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.y + 10f,
                                                                                               GameObject.Find("PlayerLeftText").GetComponent<Transform>().position.z);
        }
	}
}
