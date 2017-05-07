using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchSceneTitle : UnityEngine.MonoBehaviour {

    public void WhenPlayButtonPressed() {
        SceneManager.LoadScene("Title");
    }
}
