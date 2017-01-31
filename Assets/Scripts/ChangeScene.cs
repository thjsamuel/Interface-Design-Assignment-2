using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public string nextScene;

    public void OnClick()
    {
        SceneManager.LoadScene(nextScene);
    }
}
