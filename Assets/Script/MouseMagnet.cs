using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tobii.EyeTracking;

public class MouseMagnet : MonoBehaviour {

   private  Rigidbody rb;

    public float smoothing = 5;

    public Renderer isTracking;

    public float magnetForce = 1.0f;

    public bool useMouse = true;

    private Vector3 prevPos = new Vector3();

    // Use this for initialization
    void Start () {
        EyeTracking.Initialize();
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 watchingPos = new Vector3();
        if (useMouse)
            watchingPos = Input.mousePosition;

        GazeTracking gazeTracking = EyeTracking.GetGazeTrackingStatus();
        if (gazeTracking.IsTrackingEyeGaze)
        {
            isTracking.material.color = Color.green; //C#
            GazePoint gp = EyeTracking.GetGazePoint();
            if (gp.IsValid)
                watchingPos = gp.Screen;
        }
        else
            isTracking.material.color = Color.red; //C#


        //Debug.Log(watchingPos);
        if (watchingPos != Vector3.zero) { 
            Ray ray = Camera.main.ScreenPointToRay(watchingPos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("Collision");
                //transform.position = hit.point + new Vector3(0, GetComponent<Collider>().bounds.size.y / 2, 0);
                if (rb)
                {
                    Vector3 magPos = new Vector3();
                    if (prevPos == Vector3.zero)
                        magPos = hit.point;
                    else
                        magPos = (hit.point +smoothing * prevPos)/(smoothing+1);
                    prevPos = magPos;
                    rb.AddForce(magnetForce * (magPos - transform.position));
                    transform.LookAt(magPos);

                }
            }
        }
    }

}
