using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public Camera mainCamera;
   // public Canvas ca;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //for(int i =0; i<ca.Length; i++)
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward, mainCamera.transform.position);
        //transform.Rotate(0, 1000, 0, Space.World);

    }
}
