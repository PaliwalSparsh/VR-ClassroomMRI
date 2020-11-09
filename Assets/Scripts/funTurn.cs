using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funTurn : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
        speed = 2000;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed*Time.deltaTime);	
	}
}
