using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public string nextScene;

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClick()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
