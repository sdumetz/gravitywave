using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMagnet : MonoBehaviour {

   private  Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Collision");
            //transform.position = hit.point + new Vector3(0, GetComponent<Collider>().bounds.size.y / 2, 0);
            if (rb)
                rb.AddForce(hit.point - transform.position );
        }
    }

}
