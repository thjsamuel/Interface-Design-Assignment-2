using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class move : MonoBehaviour {
    private bool b_isUsingJoystick;
    private Animator mymy;
    public Image joystick; // joystick background image with rect position we need
    GameObject[] collideList;
    Vector3[] collidePosList;
    Vector3 playerCamCoord;
    Camera camera;

    private GameObject joyStick;
    private Vector3 joyStickStartingPos;
    
	// Use this for initialization
	void Start () {
        mymy = GetComponent<Animator>();
        GameObject camera_go = GameObject.Find("Main Camera");
        camera = camera_go.GetComponent<Camera>();
        collideList = GameObject.FindGameObjectsWithTag("Collidable");

        joyStick = GameObject.Find("Joystick thumbpad");
        //joyStickStartingPos = new Vector3(196, 196, 1); // change to get position
        joyStickStartingPos = joyStick.transform.position;
	}

    bool checkCollisionBetween2Objects()
    {
        Transform otherTransform; // Other object transformation
        foreach (GameObject obj in collideList)
        {
            // Get the transform of game object, collidable ones in this case
            otherTransform = obj.GetComponent<Transform>();
            // Store position of other object
            Vector3 otherPos = otherTransform.position;
            float objects_dist_square = (this.transform.position - otherPos).sqrMagnitude; // to get this object and other object distance squared
            //Vector3 thisScale = this.transform.localScale; // this object relative position + this scale
            //Vector3 otherScale = otherTransform.localScale; // other object relative position + other scale
            //float objects_scale_combined = (thisScale.x + otherScale.x); // their scale x axis added with each other to act as a distance threshold
            if ((objects_dist_square  * 0.5f) < 0.3f)
            {
                return true;
            }
        }
        return false;
    }

    bool checkCollisionWithObject(GameObject obj)
    {
        Transform otherTransform; // Other object transformation
        // Get the transform of game object, collidable ones in this case
        otherTransform = obj.GetComponent<Transform>();
        // Store position of other object
        Vector3 otherPos = otherTransform.position;
        float objects_dist_square = (this.transform.position - otherPos).sqrMagnitude; // to get this object and other object distance squared
        //Vector3 thisScale = this.transform.localScale; // this object relative position + this scale
        //Vector3 otherScale = otherTransform.localScale; // other object relative position + other scale
        //float objects_scale_combined = (thisScale.x + otherScale.x); // their scale x axis added with each other to act as a distance threshold
        if ((objects_dist_square * 0.5f) < 0.3f)
        {
            return true;
        }
        return false;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = (joyStick.transform.position - joyStickStartingPos).normalized;

        transform.position += dir * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, -1.5f);

        //float m_fSpeed = 0.01f;
        //playerCamCoord = camera.WorldToViewportPoint(this.transform.position);
        //float playerCamXForward = playerCamCoord.x + 0.01f; float playerCamXBackward = playerCamCoord.x - 0.01f; float playerCamYForward = playerCamCoord.y + 0.01f;
        //float playerCamYBackward = playerCamCoord.y - 0.01f;
        ///*check for direction of joystick input*/
        //Vector3 mouse_dir = Vector3.zero;
        //if (b_isUsingJoystick)
        //{
        //    Vector3 mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1); // get mouse position
        //    mouse_dir = (mouse_pos - joystick.rectTransform.position).normalized; // get direction mouse is moving away at
        //}
        ///**/
        //if ((Input.GetKey(KeyCode.UpArrow) || mouse_dir.y > 0) && playerCamYForward < 1) // need to get the event trigger to make sure only check if player is draggin
        //{
        //    mymy.Play("dudeAnimUp");
        //    transform.Translate(new Vector3(0, 0.01f, 0));
        //}
        //if ((Input.GetKey(KeyCode.DownArrow) || mouse_dir.y < 0) && playerCamYBackward > 0)
        //{
        //    mymy.Play("dudeAnimDown");
        //    transform.Translate(new Vector3(0, -0.01f, 0));
        //}
        //if ((Input.GetKey(KeyCode.LeftArrow) || mouse_dir.x < 0) && playerCamXBackward > 0)
        //{
        //    mymy.Play("dudeAnimLeft");
        //    transform.Translate(new Vector3(-0.01f, 0, 0));
        //}
        //if ((Input.GetKey(KeyCode.RightArrow) || mouse_dir.x > 0) && playerCamXForward < 1)
        //{
        //    mymy.Play("dudeAnimRight");
        //    transform.Translate(new Vector3(0.01f, 0, 0));
        //}
        //if (Input.GetKeyUp(KeyCode.Escape))
        //{
        //    if (Application.platform == RuntimePlatform.Android)
        //        Application.Quit();
        //}
        //if (Input.touchCount >= 3)
        //    SceneManager.LoadScene("Scene2");
        //Transform otherTransform; // Other object transformation
        //for (int i = 0; i < collideList.Length; ++i)
        //{
        //    GameObject obj = collideList[i];
        //    // Get the transform of game object, collidable ones in this case
        //    if (checkCollisionWithObject(obj))
        //    {
        //        Debug.Log("Has collided!");
        //        otherTransform = obj.GetComponent<Transform>();
        //        // Store position of other object
        //        Vector3 otherPos = otherTransform.position;
        //        Vector3 thisPos = this.transform.position;
        //        Vector3 dir = (otherPos - thisPos).normalized; // Divide by magnitude/normalize to get direction vector
        //        otherTransform.position += (dir).normalized * m_fSpeed;
        //        Debug.Log("Has moved!");
        //    }
        //}
	}

    public void isDrag()
    {
        b_isUsingJoystick = true;
    }

    public void isUp()
    {
        b_isUsingJoystick = false;
    }
}
