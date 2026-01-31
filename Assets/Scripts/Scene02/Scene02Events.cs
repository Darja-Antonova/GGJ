using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
{
    
    [SerializeField] GameObject fadeScreenIn;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    void update() 
    {

    }

    IEnumerator EventStarter()
    {
        //Event 0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
    

    }
}
