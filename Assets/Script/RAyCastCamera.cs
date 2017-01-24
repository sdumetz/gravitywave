using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAyCastCamera : MonoBehaviour {

    public Transform pointTo;
    public Transform ball;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            pointTo.position = hit.point;
            Physics.gravity = 0.5f * (hit.point - ball.position);
        }

    }
    
}
