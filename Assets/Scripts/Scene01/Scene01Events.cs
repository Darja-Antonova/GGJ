using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charHolly;
    public GameObject charJun;
    public GameObject textBox;

    [SerializeField] AudioSource Pop;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;

    void Update()
    {
        textLength = TextCreator.charCount;
    }

    private void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        //Event 0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charHolly.SetActive(true);
        yield return new WaitForSeconds(2);
        //Text function for future
        mainTextObject.SetActive(true);
        textToSpeak = "Die Asshole.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        Pop.Play();
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;

    }


IEnumerator EventOne() 
{
    //Event 1
    nextButton.SetActive(false);
    charJun.SetActive(true);
    textBox.SetActive(true);
    charName.GetComponent<TMPro.TMP_Text>().text = "Jun Char";

    textToSpeak = "Oh, you like My Chemical Romance?, Name five songs.";
    textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
    currentTextLength = textToSpeak.Length;
    TextCreator.runTextPrint = true;
    yield return new WaitForSeconds(0.05f);
    yield return new WaitForSeconds(1);
    yield return new WaitUntil(() => textLength == currentTextLength);
    yield return new WaitForSeconds(0.5f);

    Pop.Play();
    nextButton.SetActive(true);
    eventPos = 2;
}


    public void NextButton()
    {
if (eventPos == 1) 
      {
          StartCoroutine(EventOne());
      }
    }
}
