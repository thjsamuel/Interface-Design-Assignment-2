using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollThroughSkills : MonoBehaviour {

    float scrollSpeed;
    public Scrollbar scrollbar;
    float prevScrollValue;

	// Use this for initialization
	void Start () {
        scrollSpeed = 5.0f;
        prevScrollValue = scrollbar.value;
	}
	
	// Update is called once per frame
	void Update () {
        prevScrollValue = scrollbar.value - prevScrollValue * Time.deltaTime;
	}

    public void OnValueChanged()
    {
        if (scrollbar.value > prevScrollValue)
            this.transform.position += new Vector3(0, scrollSpeed);
        else if (scrollbar.value < prevScrollValue)
            this.transform.position -= new Vector3(0, scrollSpeed);
    }
}
