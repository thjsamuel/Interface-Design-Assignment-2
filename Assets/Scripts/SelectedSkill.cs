using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectedSkill : MonoBehaviour {

    private Text selectedSkill;

	// Use this for initialization
	void Start () {
        selectedSkill = transform.GetChild(0).GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void ChangeNum()
    {
       selectedSkill.text = "lol";
    }
}
