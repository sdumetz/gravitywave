using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showControls : MonoBehaviour {

    public GameObject level;

    public Material materialAndroid;
    public Material materialStandalone;


    // Use this for initialization
    void Start () {
        level.SetActive(false);
#if UNITY_STANDALONE
        GetComponent<Renderer>().material = materialStandalone;
#endif
#if UNITY_ANDROID
        GetComponent<Renderer>().material = materialAndroid;
#endif
    }

    // Update is called once per frame
    void Update () {
        if(Time.realtimeSinceStartup > 5.0f)
        {
            level.SetActive(true);
            gameObject.SetActive(false);
        }
		
	}
}
