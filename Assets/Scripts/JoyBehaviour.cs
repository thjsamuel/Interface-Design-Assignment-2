using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JoyBehaviour : MonoBehaviour {
    private Image joyBG; // joystick background
    private Image joyTP; // joystick thumbpad
    private Vector3 last_mouse_pos; // position of mouse before current frame
	// Use this for initialization
	void Start () {
        joyBG = GetComponent<Image>();
        joyTP = transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void dragging()
    {
        Vector3 mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1); // get mouse position
        float max_movement = (joyBG.rectTransform.rect.width * 0.5f - joyTP.rectTransform.rect.width * 0.5f); // half of background image's width - half of thumbpads image's width to find max distance which user can move thumbpad
        float dist_mouseFromCenter = (mouse_pos - joyBG.rectTransform.position).magnitude; // Get length of distance of mouse away from center
        if (dist_mouseFromCenter < max_movement)
            joyTP.rectTransform.position = mouse_pos; // moving thumbpad to mouse position
        else // if mouse is dragged away from joystick background
        {
            Vector3 mouse_dir = (mouse_pos - joyBG.rectTransform.position).normalized; // get direction mouse is moving away at
            float joystick_radius = (joyBG.rectTransform.rect.width * 0.5f); // joystick background width halfed is a sort of radius
            joyTP.rectTransform.position = (joyBG.rectTransform.position + mouse_dir * max_movement); // start from middle of joystick, make it move towards/in direction of mouse current direction but only to the extent of max_distance
            // to-do: viewport such that when mouse moves out of game screen, activate GoingBacktoOrigin()
        }
    }

    public void GoingBacktoOrigin()
    {
        joyTP.rectTransform.anchoredPosition = Vector3.zero;
    }

    //private bool LimitMovement(ref float collided_x, ref float collided_y)
    //{
    //    Vector3 mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);

    //    float max_movement = (joyBG.rectTransform.rect.width * 0.5f - joyTP.rectTransform.rect.width * 0.5f); // half of background image's width - half of thumbpads image's width to find max distance which user can move thumbpad
    //    Vector3 pointFromCenter = joyTP.rectTransform.position - joyBG.rectTransform.position; // joystick foreground image's distance away from center
    //    float distFromCenter = pointFromCenter.magnitude;
    //    if (distFromCenter > max_movement)
    //    {
    //        collided_x = joyTP.rectTransform.position.x;
    //        collided_y = joyTP.rectTransform.position.y;
    //        return true;
    //    }
    //    return false;
    //}
}
