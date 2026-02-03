using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplashToMain : MonoBehaviour
{
    [SerializeField] AudioSource Train;
    void Start()
    {
        StartCoroutine(SplashSequence());
        Train.Play();
    }

    IEnumerator SplashSequence()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);
    }
}
