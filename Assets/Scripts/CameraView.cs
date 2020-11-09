using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {
    public GameObject mainCamera;
    public GameObject viewCameraLeft;
    public GameObject viewCameraRight;
    public Vector3 position;
	public GameObject mriInside;
	public GameObject mriMain;
	public GameObject cubeAtom;
	public GameObject photons;

	void Start () {
		
	}
	
    public void changeCameraPosition()
    {
        if (mainCamera.transform.position != position)
        {
            mainCamera.transform.position = position;
        }
        if (!viewCameraLeft.activeSelf || !viewCameraRight.activeSelf)
        {
            viewCameraLeft.SetActive (true);
            viewCameraRight.SetActive (true);
			mriMain.SetActive (true);
			mriInside.SetActive (true);
			cubeAtom.SetActive (true);
			photons.SetActive (true);
		}
    }
    // Update is called once per frame
    void Update () {

	}
}
