using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradeButton : MonoBehaviour {

    private GameObject numSkillsPoints;
    private int currentPoints;
    private int neededPoints;

    private Button upgradeButton;

	// Use this for initialization
	void Start () {
        neededPoints = 2;
        upgradeButton = GetComponent<Button>();

        numSkillsPoints = GameObject.Find("NumSkillPoints");

        int.TryParse(numSkillsPoints.GetComponent<Text>().text, out currentPoints);
	}
	
	// Update is called once per frame
	void Update () {
	    if (currentPoints >= neededPoints)
        {
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeButton.interactable = false;
        }
	}

    public void OnClick()
    {
        currentPoints -= neededPoints;
        numSkillsPoints.GetComponent<Text>().text = currentPoints.ToString();
    }
}
