using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoublePress : MonoBehaviour {
    Touch interaction;
    Toggle toggle;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
            interaction = Input.GetTouch(0);
	}

    public void OnClick(Button clicked)
    {
        if (interaction.tapCount >= 2)
        {
            toggle = clicked.transform.GetChild(0).GetComponent<Toggle>();
            toggle.gameObject.SetActive(!toggle.gameObject.activeSelf);
            toggle.isOn = !toggle.isOn;
        }
    }
}
