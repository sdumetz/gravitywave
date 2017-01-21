using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

    private bool animate = false;
    private Vector3 rotationLeft;
    public float speedAnimation = 0.02f;


    //private Vector3 axis;
    //private float rest;

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update() {
        if (!animate)
        {
            /*if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animate = true;
                //rotationLeft += transform.rotation * new Vector3(-90, 0, 0);
                rotationLeft += new Vector3(90, 0, 0);

                //axis = Vector3.right;
                //rest = 90.0f;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                animate = true;
                //rotationLeft += transform.rotation * new Vector3(90, 0, 0);
                rotationLeft +=  new Vector3(-90, 0, 0);


                //axis = Vector3.right;
                //rest = 90.0f;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                animate = true;
                //rotationLeft += transform.rotation * new Vector3(0, 0, -90);
                rotationLeft += new Vector3(0, 0, -90);


                //axis = Vector3.forward;
                //rest = 90.0f;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                animate = true;
                //rotationLeft += transform.rotation * new Vector3(0, 0, 90);
                rotationLeft +=  new Vector3(0, 0, 90);

                //axis = Vector3.right;
                //rest = 90.0f;
            }*/
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(new Vector3(1, 0, 0), Space.World);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(new Vector3(-1, 0, 0), Space.World);
                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(new Vector3(0, 0, -1), Space.World);


                //axis = Vector3.forward;
                //rest = 90.0f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0, 0, 1), Space.World);
            }
        }
        if (animate)
        {
            //if(rest < 1.0f)
            if (rotationLeft.magnitude < 1.0f)
            {
                transform.Rotate(rotationLeft, Space.World);
                animate = false;
                rotationLeft = Vector2.zero;

                //transform.Rotate(axis, rest);
                //rest = 0.0f;

            }
            else
            {
                Vector3 r = Vector3.Lerp(new Vector3(), rotationLeft, speedAnimation);
                transform.Rotate(r,Space.World);
                rotationLeft -= r;

                //float r = Mathf.Lerp(0.0f, rest, speedAnimation);
                //float r = 1.0f;
                //transform.Rotate(axis, rest);
                //rest -= r;


            }

        }

    }
}
