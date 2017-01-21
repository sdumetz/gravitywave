using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

    private bool animate = false;
    private Vector3 rotationLeft;
    public float speedAnimation = 0.02f;



    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update() {
        if (!animate)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animate = true;
                rotationLeft += transform.rotation * new Vector3(-90, 0, 0);

                
                //transform.Rotate(-90,0,0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                animate = true;
                rotationLeft += transform.rotation * new Vector3(90, 0, 0);


                //transform.Rotate(90, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                animate = true;
                rotationLeft += transform.rotation * new Vector3(0, 0, -90);


                //transform.Rotate(0, 0, -90);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                animate = true;
                rotationLeft += transform.rotation * new Vector3(0, 0, 90);

                //transform.Rotate(0, 0, 90);
            }
        }
        if (animate)
        {

            if (rotationLeft.magnitude < 1.0f)
            {
                transform.Rotate(rotationLeft);
                animate = false;
                rotationLeft = Vector2.zero;


            }
            else
            {
                Vector3 r = Vector3.Lerp(new Vector3(), rotationLeft, speedAnimation);
                transform.Rotate(r);
                rotationLeft -= r;


            }

        }

    }
}
