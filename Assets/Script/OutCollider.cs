using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCollider : MonoBehaviour {
    public Transform sphere;
    public Transform cube;

    private Vector3 initPos;
    // Use this for initialization

    private bool animate = false;

    void Start () {
        if (sphere)
            initPos = sphere.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (animate)
        {
            //float magnitude = Mathf.Sqrt(cube.rotation.w * cube.rotation.w + cube.rotation.x * cube.rotation.x + cube.rotation.y * cube.rotation.y + cube.rotation.z * cube.rotation.z);
            float magnitude = cube.rotation.eulerAngles.magnitude;
            //Debug.Log(magnitude);
            if (magnitude < 5.0f)
            {
                cube.rotation = new Quaternion();
                animate = false;
                sphere.gameObject.SetActive(true);
                sphere.position = initPos;


            }
            else
            {
                //Debug.Log("ndju");
                Quaternion r = Quaternion.Lerp(cube.rotation, Quaternion.identity, 0.05f);
                cube.rotation = r;


            }

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        animate = true;
        //cube.rotation = new Quaternion();
        sphere.gameObject.SetActive(false);

    }
}
