using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCollider : MonoBehaviour {

    private bool ended = false;
    public Transform sphere;
    public Transform cam;
    public TextMesh textM;
    public GameObject reussite;
    public GameObject echec;

    private Vector3 initPos;

    private float endTime = 0.0f;

    private float startTime;
	// Use this for initialization
	void Start () {
        startTime = Time.realtimeSinceStartup;
        if (sphere)
            initPos = sphere.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ended)
            {
                ended = false;
                //FindObjectOfType<Camera>().transform.position -= new Vector3(5000, 0, 0);
                startTime = Time.realtimeSinceStartup;
                reussite.SetActive(false);
                echec.SetActive(false);
            
        }
            cam.rotation = new Quaternion();
            sphere.position = initPos;
            sphere.gameObject.SetActive(true);
        }

#if UNITY_ANDROID
        if (ended)
        {
            if(Time.realtimeSinceStartup - endTime > 5.0f)
            {
                ended = false;
                startTime = Time.realtimeSinceStartup;
                reussite.SetActive(false);
                echec.SetActive(false);
                sphere.gameObject.SetActive(true);
                sphere.position = initPos;
            }
        }
#endif




        }

    void OnTriggerEnter(Collider coll)
    {
        if (!ended)
        {
            if (FindObjectOfType<CheckPoint>().done)
                reussite.SetActive(true);
            else
                echec.SetActive(true);

            //FindObjectOfType<Camera>().transform.position += new Vector3(5000, 0, 0);
            textM.text = Mathf.Round(Time.realtimeSinceStartup - startTime).ToString() + "s";
            //print(Time.realtimeSinceStartup);
            ended = true;
            
            sphere.gameObject.SetActive(false);




            FindObjectOfType<CheckPoint>().done = false;

            endTime = Time.realtimeSinceStartup;

        }

    }
}
