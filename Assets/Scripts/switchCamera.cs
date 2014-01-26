using UnityEngine;
using System.Collections;

public class switchCamera : MonoBehaviour {
	
	public Camera camera;
	public Camera camera2;
	
	
	private Camera[] cameras;
	private int currentCameraIndex = 0;
	private Camera currentCamera;
	
	// Use this for initialization
	void Start()
	{
		cameras = new Camera[] { camera, camera2};//this is the array of cameras
		currentCamera = camera; //When the program start the main camera is selected as the default camera
		ChangeView();
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Tab))
		{
			currentCameraIndex++;
			if (currentCameraIndex > cameras.Length-1)
				currentCameraIndex = 0;
			ChangeView();
		}
	}
	
	void ChangeView()
	{
		currentCamera.enabled = false;
		currentCamera = cameras[currentCameraIndex];
		currentCamera.enabled = true;
	}
}
