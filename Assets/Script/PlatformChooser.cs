using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformChooser : MonoBehaviour {

	// Use this for initialization
	void Start () {
#if !UNITY_ANDROID
        GetComponent<GvrHead>().enabled = false;
        GetComponent<GvrViewer>().enabled = false;
        GetComponent<StereoController>().enabled = false;
#endif
#if !UNITY_STANDALONE
        GetComponent<EyeRotator>().enabled = false;
#endif
    }

    // Update is called once per frame
    void Update () {
		
	}
}
