using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PressTitleButton : MonoBehaviour {

    private Vector3 SelectedPos;
    public AudioClip ButtonSound;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().PlayOneShot(ButtonSound);
            SelectedPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                       Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(SelectedPos, Vector2.zero, 0f);

            if (hit.transform.gameObject.CompareTag("Title")) {
                GameObject switchscene = GameObject.Find("SwitchSceneTitle");
                switchscene.GetComponent<SwitchSceneTitle>().WhenPlayButtonPressed();
            }
        }
    }
}
