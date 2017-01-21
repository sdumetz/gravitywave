using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tobii.EyeTracking;

public class EyeRotator : MonoBehaviour {

    public Renderer isTracking;
    private Vector3 prevPos = new Vector3();
    public float smoothing = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 watchingPos = new Vector3();

        GazeTracking gazeTracking = EyeTracking.GetGazeTrackingStatus();
        if (gazeTracking.IsTrackingEyeGaze)
        {
            isTracking.material.color = Color.green; //C#
            GazePoint gp = EyeTracking.GetGazePoint();
            if (gp.IsValid)
                watchingPos = gp.Screen;

            Vector3 magPos = watchingPos;
            if (prevPos != Vector3.zero)
                magPos = (watchingPos + smoothing * prevPos) / (smoothing + 1);
            prevPos = watchingPos;
            //rb.AddForce(magnetForce * (magPos - transform.position));
            //transform.LookAt(magPos);

            Vector3 rot = new Vector3((watchingPos.x - Screen.resolutions[0].width/2.0f) / Screen.resolutions[0].width, (watchingPos.x - Screen.resolutions[0].height / 2.0f) / Screen.resolutions[0].height, 0.0f);

            
        }
        else
            isTracking.material.color = Color.red; //C#



    }
}
