using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroEvents : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject textBox;

    //[SerializeField] AudioSource Pop;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;

    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;

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
        textToSpeak = "The evening is filled with a peaceful energy as you drive towards the convention you’ve been waiting to attend all year.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        //Pop.Play();
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

        textToSpeak = "The low hum of your radio occupies your thoughts until suddenly...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        //Pop.Play();
        nextButton.SetActive(true);
        eventPos = 2;
    }


    IEnumerator EventTwo()
    {
        //Event 2
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "*BAM*";
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

        textToSpeak = "Your car stops.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //Event 4
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "“Goddamnit! Not now!”";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //Event 5
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "You dread seeing the damage that has happened to your car.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //Event 6
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "With hesitation you step out.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        //Event 7
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "“A flat tire... perfect. Just what I needed.” you grumble.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 8;
    }

    IEnumerator EventEight()
    {
        //Event 8
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "With a sigh, you pull out your phone to call for roadside assistance. Might as well try to do something about your broken-down car.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 9;
    }

    IEnumerator EventNine()
    {
        //Event 9
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "“....” you stare blankly at your phone, your one possible saviour in this situation.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 10;
    }

    IEnumerator EventTen()
    {
        //Event 10
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "No signal. Not even a single bar...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 11;
    }

    IEnumerator EventEleven()
    {
        //Event 11
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "Disgruntled, you start wandering on the side of the road, waving around your phone frantically for any signs of life on the network.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 12;
    }

    IEnumerator EventTwelve()
    {
        //Event 12
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "“Nothing at all... what should I do...” you think to yourself.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 13;
    }

    IEnumerator EventThirteen()
    {
        //Event 13
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "All hope feels lost when all of a sudden you see it in the distance. Almost like it popped out of nowhere.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 14;
    }

    IEnumerator EventFourteen()
    {
        //Event 14
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "You didn’t see any mention of it when searching for a place to stay.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 15;
    }

    IEnumerator EventFifteen()
    {
        //Event 15
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "A motel.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 16;
    }

    IEnumerator EventSixteen()
    {
        //Event 16
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "“Wraithwood Lodge” the neon sign reads.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 17;
    }

    IEnumerator EventSeventeen()
    {
        //Event 17
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "It doesn’t look like the greatest of establishments, one you would typically avoid, but the times are desperate and you need service – a working phone, anything.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 18;
    }

    IEnumerator EventEighteen()
    {
        //Event 18
        nextButton.SetActive(false);
        textBox.SetActive(true);

        textToSpeak = "You start making your way towards the motel.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 19;
    }
    IEnumerator EventNineteen()
    {
        //Event 19
        nextButton.SetActive(false);
        textBox.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 19;
        SceneManager.LoadScene(4);
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
        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
        if (eventPos == 8)
        {
            StartCoroutine(EventEight());
        }
        if (eventPos == 9)
        {
            StartCoroutine(EventNine());
        }
        if (eventPos == 10)
        {
            StartCoroutine(EventTen());
        }
        if (eventPos == 11)
        {
            StartCoroutine(EventEleven());
        }
        if (eventPos == 12)
        {
            StartCoroutine(EventTwelve());
        }
        if (eventPos == 13)
        {
            StartCoroutine(EventThirteen());
        }
        if (eventPos == 14)
        {
            StartCoroutine(EventFourteen());
        }
        if (eventPos == 15)
        {
            StartCoroutine(EventFifteen());
        }
        if (eventPos == 16)
        {
            StartCoroutine(EventSixteen());
        }
        if (eventPos == 17)
        {
            StartCoroutine(EventSeventeen());
        }
        if (eventPos == 18)
        {
            StartCoroutine(EventEighteen());
        }
        if (eventPos == 19)
        {
            StartCoroutine(EventNineteen());
        }
    }
}
