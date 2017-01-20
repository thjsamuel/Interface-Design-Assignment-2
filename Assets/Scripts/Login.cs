using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void clickPlay()
    {
        SceneManager.LoadScene("Login");
    }
}
