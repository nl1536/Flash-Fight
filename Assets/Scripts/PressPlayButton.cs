using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlayButton : MonoBehaviour
{

	private Vector3 SelectedPos;
    public AudioClip ButtonSound;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		if (Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().PlayOneShot(ButtonSound);
			SelectedPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
									   Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
			RaycastHit2D hit = Physics2D.Raycast(SelectedPos, Vector2.zero, 0f);

			if (hit.transform.gameObject.CompareTag("Play")) {
				GameObject switchscene = GameObject.Find("SwitchScenePlay");
				switchscene.GetComponent<SwitchScene>().WhenPlayButtonPressed();
			}
		}
	}
}