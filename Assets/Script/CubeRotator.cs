using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

    private bool animate = false;
    private Vector3 rotationLeft;
    public float speedAnimation = 0.02f;
    public Space refspace = Space.World;
    //private Vector3 axis;
    //private float rest;

    public float gravityFactor = 5.0f;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update() {

        //Vector3 eulers = transform.localRotation.eulerAngles;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(-1, 0, 0), refspace);
            //eulers += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(1, 0, 0), refspace);
            //eulers += new Vector3(1, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0), refspace);
            //eulers += new Vector3(0, 0, 1);
            //axis = Vector3.forward;
            //rest = 90.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -1, 0), refspace);
            //eulers += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -1), refspace);
            //eulers += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, 1), refspace);
           // eulers += new Vector3(0, 1, 0);
        }
        //transform.localRotation = Quaternion.Euler(eulers);

        //Physics.gravity = gravityFactor * transform.forward;
    }
}
