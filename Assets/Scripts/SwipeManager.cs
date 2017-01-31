using UnityEngine;
using System.Collections;

public enum SwipeDirection
{
    NONE = 0,
    LEFT = 1,
    RIGHT = 2,
    UP = 4,
    DOWN = 8,
    //LEFTDOWN = 9,
    //LEFTUP = 5,
    //RIGHTDOWN = 10,
    //RIGHTUP = 6,
}

public class SwipeManager : MonoBehaviour {

    private static SwipeManager instance;
    public static SwipeManager Instance{get {return instance;}}
    public SwipeDirection Direction { set; get; }

    private Vector3 touchPos;
    private float swipeResistanceX = 50.0f;
    private float swipeResistanceY = 100.0f;
    private bool bReleased = true;

    public SwipeDirection[] swipesArray;
    public int MAX_SWIPES = 5;
    private int swipeIndex = 0;

    void Start()
    {
        instance = this;
        swipesArray = new SwipeDirection[MAX_SWIPES];
    }

	// Update is called once per frame
	void Update () 
    {
        Direction = SwipeDirection.NONE;

	    if (Input.GetMouseButtonDown(0))
        {
            bReleased = false;
            touchPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            bReleased = true;
        }

        if (!bReleased)
        {
            Vector2 deltaSwipe = touchPos - Input.mousePosition;

            if (Mathf.Abs(deltaSwipe.x) > swipeResistanceX)
            {
                // Swipe on x axis
                Direction |= (deltaSwipe.x < 0) ? SwipeDirection.RIGHT : SwipeDirection.LEFT;
            }

            if (Mathf.Abs(deltaSwipe.y) > swipeResistanceY)
            {
                // Swipe on y axis
                Direction |= (deltaSwipe.y < 0) ? SwipeDirection.UP : SwipeDirection.DOWN;
            }
        }

        if (Direction != SwipeDirection.NONE)
        {
            if (swipeIndex < MAX_SWIPES)
            {
                if (swipeIndex == 0)
                {
                    swipesArray[swipeIndex] = Direction;
                    ++swipeIndex;
                }
                else if (Direction != swipesArray[swipeIndex - 1])
                {
                    swipesArray[swipeIndex] = Direction;
                    ++swipeIndex;
                }
            }

            //Debug.Log(index);
        }

        if (swipeIndex == MAX_SWIPES)
        {
            swipeIndex = 0;
        }

        Debug.Log(swipeIndex);
	}

    public bool isSwiping(SwipeDirection dir)
    {
        return (Direction & dir) == dir;
    }
}
