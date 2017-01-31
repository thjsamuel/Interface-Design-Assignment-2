using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PinchZoom : MonoBehaviour {

    private Image theImage;
    public float zoomSpeed = 0.1f;
    private float zoomValue = 0.0f;

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

            zoomValue += deltaMagDiff * zoomSpeed;

            //theImage.transform.localScale += new Vector3(Mathf.Clamp(zoomValue, 0.0f, 5.0f), Mathf.Clamp(zoomValue, 0.0f, 5.0f));
            theImage.transform.localScale += new Vector3(zoomValue, zoomValue);
        }

        if (Input.touchCount == 4)
        {
            SceneManager.LoadScene("MapPage");
        }
	}
}
