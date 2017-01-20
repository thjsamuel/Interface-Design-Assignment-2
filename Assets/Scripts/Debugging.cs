using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Debugging : MonoBehaviour {
    public Text debugTxt;
	// Use this for initialization
	void Start () {
        debugTxt.text = "Started";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void clickA()
    {
        debugTxt.text = "A";
    }

    public void clickB()
    {
        debugTxt.text = "B";
    }
}
