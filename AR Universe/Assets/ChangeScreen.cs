using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour {
  //  public Button btn;
	// Use this for initialization
	void Start () {
        //Button btn0 = btn.GetComponent<Button>();
        //btn.onClick.AddListener(ChangeScreenOne);
		
    }
	
	// Update is called once per frame
	void Update () {

		
	}

    public void ChangeScreenOne()
    {
        SceneManager.LoadScene("show Planet");

    }
}
