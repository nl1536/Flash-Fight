using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchSceneCredits : UnityEngine.MonoBehaviour {

    public void WhenPlayButtonPressed() {
        SceneManager.LoadScene("Credits");
    }
}
