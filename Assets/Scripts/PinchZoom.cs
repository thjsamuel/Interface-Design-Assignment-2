using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinchZoom : MonoBehaviour {

    private Image theImage;
    public float zoomSpeed = 0.5f;

    void Start()
    {
        theImage = GetComponent<Image>();
    }

	// Update is called once per frame
	void Update () 
    {
	    if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagDiff = prevTouchDeltaMag - touchDeltaMag;

            theImage.transform.localScale += new Vector3(zoomSpeed, zoomSpeed, 0);
        }
	}
}
