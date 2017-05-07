using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

    public Sprite CountdownThree;
    public Sprite CountdownTwo;
    public Sprite CountdownOne;

    public AudioClip Three;
    public AudioClip Two;
    public AudioClip One;

    float timeUntilSwitch;
    public bool gamePlay;

	// Use this for initialization
	void Start () {

        timeUntilSwitch = 1f;
        GetComponent<SpriteRenderer>().sprite = CountdownThree;
        gamePlay = false;
	}
	
	// Update is called once per frame
	void Update () {

        timeUntilSwitch -= Time.deltaTime;
        
        if (timeUntilSwitch > .94f && timeUntilSwitch < .97f && GetComponent<SpriteRenderer>().sprite == CountdownThree) {
            GetComponent<AudioSource>().PlayOneShot(Three);
        }
        if (timeUntilSwitch <= 0f && GetComponent<SpriteRenderer>().sprite == CountdownThree) {
            GetComponent<SpriteRenderer>().sprite = CountdownTwo;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255, 0, 255);
            timeUntilSwitch = 1f;
        }
        if (timeUntilSwitch > .97f && timeUntilSwitch < 1f && GetComponent<SpriteRenderer>().sprite == CountdownTwo) {
            GetComponent<AudioSource>().PlayOneShot(Two);
        }
        if (timeUntilSwitch <= 0f && GetComponent<SpriteRenderer>().sprite == CountdownTwo) {
            GetComponent<SpriteRenderer>().sprite = CountdownOne;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 0, 0, 255);
            timeUntilSwitch = 1f;
        }
        if (timeUntilSwitch > .97f && timeUntilSwitch < 1f && GetComponent<SpriteRenderer>().sprite == CountdownOne) {
            GetComponent<AudioSource>().PlayOneShot(One);
        }
        if (timeUntilSwitch <= 0f && GetComponent<SpriteRenderer>().sprite == CountdownOne) {
            GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Shade").GetComponent<SpriteRenderer>().color = new Vector4(0,0,0, GameObject.Find("Shade").GetComponent<SpriteRenderer>().color.a - 1f);
            gamePlay = true;
        }
	}
}
