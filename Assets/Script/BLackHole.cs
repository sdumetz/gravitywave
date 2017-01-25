using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLackHole : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(target.transform.forward,6);
	}
}
