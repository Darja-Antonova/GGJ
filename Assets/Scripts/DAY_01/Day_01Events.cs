using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Day_01Events : MonoBehaviour
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
    [SerializeField] GameObject charAnnie;

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
        textToSpeak = "You wake up confused and dreary.";
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
        charAnnie.SetActive(false);

        textToSpeak = "It was difficult to sleep through the night; you swore that this must be the world’s uncomfiest bed.";
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

        textToSpeak = "You get up quickly, eager to leave this place.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        //Event 3
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "As you step out of the room, you feel a chill run down your spine. There’s somebody watching you from afar...";
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
        eventPos = 4;
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
        charAnnie.SetActive(true);

        //Switch to Interaction Scene
        nextButton.SetActive(false);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 5;
        SceneManager.LoadScene(6);

    }

    IEnumerator SecondOptionSeq()
    {
        //Event 15

        firstOption.SetActive(false);
        secondOption.SetActive(false);
        charAnnie.SetActive(false);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "You decided that it was not worth it and began walking down the hallway. You try to ignore the steady gaze following your back as you make your way downstairs...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(false);
        eventPos = 4;

        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        charAnnie.SetActive(false);
        mainTextObject.SetActive(false);
        SceneManager.LoadScene(7);
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
        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
    }
}
