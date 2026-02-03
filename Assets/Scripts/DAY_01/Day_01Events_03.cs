using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Day_01Events_03 : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject textBox;

    [SerializeField] AudioSource Pop;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;

    [SerializeField] GameObject firstOption;
    [SerializeField] GameObject secondOption;
    [SerializeField] GameObject charMarv;

    private void Start()
    {
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
        yield return new WaitForSeconds(2);
        //Text function for future
        mainTextObject.SetActive(true);
        textToSpeak = "As you step inside the lobby, a new face appears by the front desk counter. His expression dim and exasperated as he taps his foot on the floor.";
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
        textBox.SetActive(true);
        charMarv.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = "???";

        textToSpeak = "“God, what could POSSIBLY be taking this damn long?”, the mysterious figure snarls.";
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


    IEnumerator EventTwo()
    {
        //Event 2
        nextButton.SetActive(false);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";

        textToSpeak = "You lower your eyes and try to make your way past when you’re reminded of last night. Is the clerk still not present?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(false);
        textBox.SetActive(true);

        mainTextObject.SetActive(false);
        firstOption.SetActive(true);
        secondOption.SetActive(true);
        eventPos = 3;
    }

    public void FirstOption()
    {
        StartCoroutine(FirstOptionSeq());
    }

    public void SecondOption()
    {
        StartCoroutine(SecondOptionSeq());
    }

    IEnumerator FirstOptionSeq()
    {
        //Event 5

        firstOption.SetActive(false);
        secondOption.SetActive(false);
        charMarv.SetActive(false);

        //Switch to Interaction Scene
        nextButton.SetActive(false);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 5;
        SceneManager.LoadScene(8);

    }

    IEnumerator SecondOptionSeq()
    {
        //Event 15

        firstOption.SetActive(false);
        secondOption.SetActive(false);
        charMarv.SetActive(false);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "You feel for him, it will be a long while before the clerk comes out... but you decide that you have more important matters to attend to.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "Suddenly, you hear screaming coming from a nearby room.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(false);
        eventPos = 3;
        
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(10);
        charMarv.SetActive(false);
        mainTextObject.SetActive(false);
        SceneManager.LoadScene(8);
    }


    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
    }
}