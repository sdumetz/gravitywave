using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDependantOrientation : MonoBehaviour {

	// Use this for initialization
	void Start () {
#if UNITY_ANDROID
        transform.rotation = new Quaternion();
#endif

    }

    // Update is called once per frame
    void Update () {
		
	}
}
