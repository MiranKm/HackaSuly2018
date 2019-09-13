using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenSphere : MonoBehaviour {

    public Vector3 cord;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(cord);
	}
}
