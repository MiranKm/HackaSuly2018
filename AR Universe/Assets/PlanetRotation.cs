using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

    public Texture[] materials;
    public Renderer rend;
	public int counter = 0;
	public Texture defaultTexture;

    [SerializeField]
     private Vector3 rotationProperty;
	// Use this for initialization
	void Start () {
       rend = GetComponent<Renderer>();
		//		setting the texture array to the first element in the material array;
		//		rend.material.SetTexture("_MainTex", materials[0]);


    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(rotationProperty * 1000);

		transform.Rotate (0, 1000, 0, Space.World);
	}


   public void ChangeMat()
    {
        
		counter++;
		rend.material.SetTexture ("_MainTex", materials [counter]);
		if (counter == materials.Length - 1) {
			counter = -1;


		}

    }

}
