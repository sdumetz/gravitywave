using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tobii.EyeTracking;

public class EyeRotator : MonoBehaviour {
    
    private Vector3 prevPos = new Vector3();
    public float smoothing = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*Vector3 watchingPos = new Vector3();
        watchingPos = Input.mousePosition;
        Vector3 rot = new Vector3(2.0f * (watchingPos.y - Screen.height / 2.0f) / Screen.height, 0.0f,  -2.0f * (watchingPos.x - Screen.width / 2.0f) / Screen.width);
        Debug.Log(rot);
        transform.Rotate(rot, Space.World);*/

        

        Vector3 watchingPos = new Vector3();

        GazeTracking gazeTracking = EyeTracking.GetGazeTrackingStatus();
        if (gazeTracking.IsTrackingEyeGaze)
        {
            GazePoint gp = EyeTracking.GetGazePoint();
            if (gp.IsValid)
                watchingPos = gp.Screen;

            Vector3 magPos = watchingPos;
            if (prevPos != Vector3.zero)
                magPos = (watchingPos + smoothing * prevPos) / (smoothing + 1);
            prevPos = watchingPos;
            //rb.AddForce(magnetForce * (magPos - transform.position));
            //transform.LookAt(magPos);
            watchingPos *= 1.0f;
            //watchingPos.x = Mathf.Pow(watchingPos.x, 3);
            //watchingPos.y = Mathf.Pow(watchingPos.y, 3);


            Vector3 rot = new Vector3( -1.0f * (watchingPos.y - Screen.height / 2.0f) / Screen.height, 1.0f * (watchingPos.x - Screen.width / 2.0f) / Screen.width,0.0f);
            //Debug.Log(rot);
            transform.Rotate(rot, Space.Self);
        }




    }
}
