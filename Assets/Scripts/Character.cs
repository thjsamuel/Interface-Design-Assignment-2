using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Character : MonoBehaviour {

    public static int m_numSkillPoints = 0;
    public static Text numSkillPointsText;

	// Use this for initialization
	void Start () {
        numSkillPointsText.text = m_numSkillPoints.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        numSkillPointsText.text = m_numSkillPoints.ToString();
	}
}
