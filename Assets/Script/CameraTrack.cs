using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Sphere");
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform, Vector3.up);
    }
}
