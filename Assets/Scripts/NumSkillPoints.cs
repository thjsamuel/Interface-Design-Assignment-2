using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumSkillPoints : MonoBehaviour {

    private Text numSkillPoints;

	// Use this for initialization
	void Start () {
        numSkillPoints = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //numSkillPoints = Character.numSkillPointsText;
        numSkillPoints.text = "hi";
	}
}
