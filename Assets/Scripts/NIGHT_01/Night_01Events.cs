using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Night_01Events : MonoBehaviour
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
    [SerializeField] GameObject charMonA;
    [SerializeField] GameObject charMonB;
    [SerializeField] GameObject charMonC;
    [SerializeField] GameObject charMonD;

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
        textToSpeak = "An awful, clawing noise echoes from outside your room. You sit up in a panic, the sounds seeming to come closer and closer... despite it just being you in the room.";
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

        textToSpeak = "Dazed, you look around your dank room. Even if something was in this room with you, it’d be difficult to see due to the discolouration and small size.";
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

        textToSpeak = "There’s no way you can fall back asleep with all these noises assaulting your ears. You decide to seek the source of it.";
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
        charMonA.SetActive(true);

        textToSpeak = "Stepping out was a mistake. A horrible, incredible creature stands atop the stairs, glaring. Its teeth gleam in the stream of moonlight entering the side window. What in the hell is wrong with this motel?";
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

        textToSpeak = "The devilish, sanguine coloured creature slowly lowers its gaze towards you.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "?!?!";

        textToSpeak = "“I... will... eat... you. I WILL...... EAT....... YOU.” It shrieks in a low tone as it starts to charge at you.";
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
        charMonA.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";

        textToSpeak = "“Oh hell no...” You think to yourself as you quickly duck under the creature, sprinting down the stairs when suddenly... you fall down the last few steps of the stairs.";
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
        charMonB.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "?!?!";

        textToSpeak = "You turn to look behind you when a massive centipede greets you. “Oh little bug, did you not see me there?~” the insect chuckles, its eyes rolling back.";
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
        charMonB.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";

        textToSpeak = "As you scramble to pick yourself up, the term “little bug” seems familiar to you... but you don’t have time to dwell on it.";
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

        textToSpeak = "You know you won’t make it out alive of this place if you don’t leave right now. You heave and wheeze as you press onwards, running as fast as your legs can carry you through the lobby.";
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

        textToSpeak = "But you don’t get far.";
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
        charMonC.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";

        textToSpeak = "You feel thick, fuzzy legs wrap around your legs as they try to drag you back. “NO! LET ME GO! LET ME OUT OF HERE” you scream, kicking and thrashing around on the ground like a helpless child. You were so close... so close to getting out when...";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "?!?!";

        textToSpeak = "“fslkk fslkk rrsl hrr krslst rrsl” the spider almost sounds like it’s reprimanding you as it recoils slightly from... pain? You take this opportunity to wriggle yourself out of its grasp.";
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
        charMonC.SetActive(false);
        charName.GetComponent<TMPro.TMP_Text>().text = " ";

        textToSpeak = "As the door appears in sight, you fling it open, not daring to look back on what is happening back there. Surely this is just a nightmare... there’s no way this could be your reality.";
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
        charMonD.SetActive(true);

        textToSpeak = "You make it halfway across the parking lot when it appears before you. An inky, dark, mess with its mouth agape, standing right in front of you.";
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
        charName.GetComponent<TMPro.TMP_Text>().text = "?!?!";

        textToSpeak = "“Not. Yet.” the hoarse voice commands, sending your vision to the abyss as everything darkens around you.";
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
        charMonD.SetActive(false);
        nextButton.SetActive(false);
        textBox.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 16;
        SceneManager.LoadScene(11);
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
    }
}
