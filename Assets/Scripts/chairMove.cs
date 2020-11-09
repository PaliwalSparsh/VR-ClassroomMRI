using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairMove : MonoBehaviour {
    public int chairSpeed;
    public GameObject viewCamera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= 2200) {
            transform.Translate(Vector3.left * chairSpeed * Time.deltaTime);
        }

        if (transform.position.x >= 2200 && transform.position.z > 30) {
            transform.Translate(Vector3.forward * chairSpeed * Time.deltaTime);
        }

        if(transform.position.x >= 2200 && transform.position.z > 30 && transform.position.z < 46)
        {
            viewCamera.SetActive(true);
            GetComponent<chairMove>().enabled = false;
        }

	}
}
