using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplashToMain : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(SplashSequence());
    }

    IEnumerator SplashSequence()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);
    }
}
