using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwapGender : MonoBehaviour {

    private Image thePlayerImage;
    public Sprite targetSprite;

    void Update()
    {
        thePlayerImage = GameObject.Find("PlayerImage").GetComponent<Image>();
    }

    public void OnClick()
    {
        if (thePlayerImage != targetSprite)
        {
            thePlayerImage.sprite = targetSprite;
        }
    }
}
