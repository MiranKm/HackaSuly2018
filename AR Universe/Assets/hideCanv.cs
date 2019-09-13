using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCanv : MonoBehaviour {

    public Canvas cc;
    public MeshRenderer[] mr;




	void Start () {
        mr = GetComponent<MeshRenderer[]>();

        
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach(var m in mr)
        {
            if (m.isVisible)
            {
                cc.enabled = false;
                //  StartCoroutine(Example());

            }
        }
        //if (mr.)
        //{
        //    cc.enabled = false;
        //  //  StartCoroutine(Example());

        //}




    }



    //IEnumerator Example()
    //{
    //    print(Time.time);
    //    yield return new WaitForSeconds(3);
    //    print(Time.time);
    //    SceneManager.LoadScene("show Planet");

    //}
}
