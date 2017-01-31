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
            toggle = clicked.GetComponent<Toggle>();
            if (toggle.IsActive() == false)
            {
                toggle.gameObject.SetActive(true);
                toggle.isOn = true;
            }
            else
            {
                toggle.gameObject.SetActive(false);
                toggle.isOn = false;
            }
        }
    }
}
