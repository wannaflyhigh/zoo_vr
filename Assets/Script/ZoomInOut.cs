using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{

	Camera maincamera;

	//初始放大倍率
	public float zoom = 60f;

	void Start()
	{
        	maincamera = GetComponent<Camera>();
	}

    
	void Update()
	{
		maincamera.fieldOfView = zoom;
	}

	public void sliderZoom(float zoomAMT)
	{
		zoom = zoomAMT;
	}

}
