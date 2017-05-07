using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchScene : UnityEngine.MonoBehaviour
{
	public void WhenPlayButtonPressed() {
		SceneManager.LoadScene("Game");
	}

}
