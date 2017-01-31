using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkillDescription : MonoBehaviour {

    private Image skillDesc;

	// Use this for initialization
	void Start () {
        skillDesc = GetComponent<Image>();
        //skillDesc.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowSkillDesc()
    {
        //skillDesc.enabled = true;
    }

    public void OnClickSkill()
    {
        SceneManager.LoadScene("CharacterSkills_Page2");
    }
}
