using System.Collections;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charHolly;
    public GameObject charJun;

    private void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charHolly.SetActive(true);
        yield return new WaitForSeconds(2);
        //Text function for future
        yield return new WaitForSeconds(2);
        charJun.SetActive(true);
    }
}
