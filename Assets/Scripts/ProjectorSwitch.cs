using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorSwitch : MonoBehaviour {
    public GameObject projectorLight;
    public GameObject projectorVideo;
    public GameObject projectorAudio;
    public GameObject ambientLight;
    public GameObject mainChair;
    public int invokeTime;
    

    // Use this for initialization
    void Start () {
		
	}

    public void AfterProjectorVideo()
    {
        projectorAudio.GetComponent<GvrAudioSource>().Stop();
        projectorLight.GetComponent<Light>().enabled = false;
        ambientLight.GetComponent<Light>().enabled = true;
        projectorVideo.GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
        // Call other script now.
        mainChair.GetComponent<afterProjection>().enabled = true;
		gameObject.SetActive (false);
    }

    public void ProjectorOn()
    {
        /*
        if (projectorLight.GetComponent<Light>().enabled)
        {
            projectorAudio.GetComponent<GvrAudioSource>().Stop();
            projectorLight.GetComponent<Light>().enabled = false;
            projectorVideo.GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
            ambientLight.GetComponent<Light>().enabled = true;
        }
        else
        {
        */

            projectorAudio.GetComponent<GvrAudioSource>().Play();
            projectorLight.GetComponent<Light>().enabled = true;
            projectorVideo.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            ambientLight.GetComponent<Light>().enabled = false;

        /*
        }
        */

        Invoke("AfterProjectorVideo", invokeTime);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
