using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeDisplayedClass : MonoBehaviour {

    private Text theClassName;
    private Text theClassDesc;

    public string targetClassName;
    public string targetClassDesc;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        theClassName = GameObject.Find("ClassName").GetComponent<Text>();
        theClassDesc = GameObject.Find("Description").GetComponent<Text>();
	}

    public void OnClick()
    {
        if (theClassName.text != targetClassName)
        {
            theClassName.text = targetClassName;
            theClassDesc.text = targetClassDesc;
        }
    }
}
