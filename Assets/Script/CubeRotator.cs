using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.Rotate(90,0,0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(-90, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -90);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 90);
        }

    }
}
