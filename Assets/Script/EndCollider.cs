using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollider : MonoBehaviour {

    private bool ended = false;
    public Transform sphere;

    private Vector3 initPos;

    private float startTime;
	// Use this for initialization
	void Start () {
        startTime = Time.realtimeSinceStartup;
        if (sphere)
            initPos = sphere.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ended)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ended = false;
                FindObjectOfType<Camera>().transform.position = new Vector3(0, 0, 0);
                sphere.position = initPos;
                startTime = Time.realtimeSinceStartup;
            }


        }
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (!ended)
        {
            FindObjectOfType<Camera>().transform.position = new Vector3(5000, 0, 0);
            FindObjectOfType<TextMesh>().text = Mathf.Round(Time.realtimeSinceStartup - startTime).ToString();
            //print(Time.realtimeSinceStartup);
            ended = true;
        }

    }
}
