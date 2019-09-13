using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class API : MonoBehaviour {

    const string url = "http://192.168.1.176:3333/model";
    public Text responseText;
    public void Request()
    {
        WWW request = new WWW(url);
        StartCoroutine(onRes(request));


    }

    private IEnumerator onRes( WWW req)
    {
        yield return req;
        responseText.text = req.text;
       // JsonUtility.FromJson<Wrapper<T>>(req.text);

    }



    [SerializeField]
    private class Wrapper<T>
    {
        public T[] array;
    }

    
}
