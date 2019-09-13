using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class DisableAR : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera)
        {
            if (mainCamera.GetComponent<VuforiaBehaviour>() != null)
            {
                mainCamera.GetComponent<VuforiaBehaviour>().enabled = false;
            }
            if (mainCamera.GetComponent<VideoBackgroundBehaviour>() != null)
            {
                mainCamera.GetComponent<VideoBackgroundBehaviour>().enabled = false;
            }
            if (mainCamera.GetComponent<DefaultInitializationErrorHandler>() != null)
            {
                mainCamera.GetComponent<DefaultInitializationErrorHandler>().enabled = false;
            }
        }
        

       
    }

    void Update()
    {

      //  StartCoroutine(Example());

    }


    //IEnumerator Example()
    //{
    //    print(Time.time);
    //    yield return new WaitForSeconds(3);
    //    print(Time.time);
    //    SceneManager.LoadScene("show Planet");

    //}
}
