using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterProjection : MonoBehaviour {
    public GameObject chairs;
    public GameObject tables;
    public int outSpeed;
    // public GameObject mriScanner;

    // Use this for initialization
    void Start () {
		


	}

	// Update is called once per frame
	void Update () {
        tables.transform.Translate(Vector3.down * outSpeed * Time.deltaTime);
        chairs.transform.Translate(Vector3.down * outSpeed * Time.deltaTime);
        // These values of chair and tables position are based of experimentation.
        if (tables.transform.position.y < 50 && chairs.transform.position.y < -800f)
        {
            GetComponent<chairMove>().enabled = true;
            GetComponent<afterProjection>().enabled = false;

        }
    }
}
