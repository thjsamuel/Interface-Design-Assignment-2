using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterSwipe : MonoBehaviour {

    private int swipeIndex = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (swipeIndex < SwipeManager.Instance.MAX_SWIPES)
        {
            if (SwipeManager.Instance.swipesArray[swipeIndex] == SwipeDirection.LEFT)
            {
                Debug.Log("Left");
                ++swipeIndex;
            }
            else if (SwipeManager.Instance.swipesArray[swipeIndex] == SwipeDirection.RIGHT)
            {
                Debug.Log("Right");
                ++swipeIndex;
            }
            else if (SwipeManager.Instance.swipesArray[swipeIndex] == SwipeDirection.UP)
            {
                Debug.Log("Up");
                ++swipeIndex;
            }
            else if (SwipeManager.Instance.swipesArray[swipeIndex] == SwipeDirection.DOWN)
            {
                Debug.Log("Down");
                ++swipeIndex;
            }
        }
	}
}
