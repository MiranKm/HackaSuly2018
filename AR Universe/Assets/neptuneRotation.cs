using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neptuneRotation : MonoBehaviour {

    public Vector3 rotaionn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotaionn, Space.World);
		
	}
}
