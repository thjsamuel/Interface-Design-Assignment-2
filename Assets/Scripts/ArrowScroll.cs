using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArrowScroll : MonoBehaviour {
    private Text lang_text;
    private string[] lang_type;
    public int index;
    public const int MAX_INDEX = 3;
	// Use this for initialization
	void Start () {
        index = 0;
        lang_text = transform.GetChild(0).GetComponent<Text>();
        Debug.Log(lang_text.text);
        lang_type = new string[MAX_INDEX];
        lang_type[0] = "English";
        lang_type[1] = "Mandarin";
        lang_type[2] = "Japanese";
	}
	
	// Update is called once per frame
	void Update () {
        if (index < 0)
            index = MAX_INDEX;
        else if (index >= MAX_INDEX)
            index = 0;
        if (!lang_text.text.Equals(lang_type[index]))
            lang_text.text = lang_type[index];
	}

    public void clickLeft()
    {
        --index;
    }

    public void clickRight()
    {
        ++index;
    }
}
