using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tobii.EyeTracking;

public class MouseMagnet : MonoBehaviour {

   private  Rigidbody rb;

    public float magnetForce = 1.0f;

    public bool useMouse = true;

    // Use this for initialization
    void Start () {
        EyeTracking.Initialize();
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 watchingPos = new Vector3();
        if(useMouse)
            watchingPos = Input.mousePosition;
        GazePoint gp = EyeTracking.GetGazePoint();
        if(gp.IsValid)
            watchingPos = gp.Screen;
        //Debug.Log(watchingPos);

        Ray ray = Camera.main.ScreenPointToRay(watchingPos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("Collision");
            //transform.position = hit.point + new Vector3(0, GetComponent<Collider>().bounds.size.y / 2, 0);
            if (rb)
                rb.AddForce(magnetForce * (hit.point - transform.position) );
        }
    }

}
