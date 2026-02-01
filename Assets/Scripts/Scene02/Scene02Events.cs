using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Events : MonoBehaviour
{
        
    public GameObject textBox;
    [SerializeField] GameObject fadeScreenIn;
    [SerializeField] GameObject charHolly;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;

    [SerializeField] GameObject leftDoorInteract;
    [SerializeField] GameObject rightDoorInteract;
    [SerializeField] GameObject charKaro;
    [SerializeField] GameObject fadeOut;

    void Start()
    {
        PlayerPrefs.SetInt("LoadState", 2);
        StartCoroutine(EventStarter());
    }

    void Update() 
    {
        textLength = TextCreator.charCount;
    }

    IEnumerator EventStarter()
    {
        //Event 0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        fadeScreenIn.SetActive(false);
        charHolly.SetActive(true);
        yield return new WaitForSeconds(2);
        //Text function for future
        mainTextObject.SetActive(true);
        textToSpeak = "Let's go.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(false);
        eventPos = 1;
        //Auto start
        yield return new WaitForSeconds(2);
        charHolly.SetActive(false);
        mainTextObject.SetActive(false);
        leftDoorInteract.SetActive(true);
        rightDoorInteract.SetActive(true);

    }

    public void LeftDoorInteract() 
    {
        StartCoroutine (LeftDoorInteractSeq());
    }

    public void RightDoorInteract() 
    {
        StartCoroutine (RightDoorInteractSeq());
    }

    IEnumerator LeftDoorInteractSeq()
    {
        leftDoorInteract.SetActive(false);
        rightDoorInteract.SetActive(false);
        charHolly.SetActive(true);
        yield return new WaitForSeconds(2);
        //Text function for future
        mainTextObject.SetActive(true);
        textToSpeak = "Are you sure?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        //nextButton.SetActive(true);
        eventPos = 1;
        //Auto start
        yield return new WaitForSeconds(2);
        charHolly.SetActive(false);
        mainTextObject.SetActive(false);
        rightDoorInteract.SetActive(true);

    }

    IEnumerator RightDoorInteractSeq()
    {
        leftDoorInteract.SetActive(false);
        rightDoorInteract.SetActive(false);
        charKaro.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        charName.GetComponent<TMPro.TMP_Text>().text = "Karo Char";
        //Text function for future
        mainTextObject.SetActive(true);
        textToSpeak = "Hey!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        //nextButton.SetActive(true);
        eventPos = 3;
        //Auto start
        yield return new WaitForSeconds(2);
        charKaro.SetActive(false);
        mainTextObject.SetActive(false);
        fadeOut.SetActive(true);

    }
}
