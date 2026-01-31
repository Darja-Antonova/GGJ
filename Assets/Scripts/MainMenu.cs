using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioSource buttonClick;
    [SerializeField] GameObject fadeOut;

    public void StartGame()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToFirstScene());
    }


IEnumerator TransferToFirstScene()
{
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene(2);
}
}
