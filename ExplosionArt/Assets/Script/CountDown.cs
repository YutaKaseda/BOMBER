using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    Text CountDownTaxt;
    int TimeLeft = 5;

    void Start()
    {
        CountDownTaxt = GetComponent<Text>();
    }

    void Update()
    {
        CountDownTaxt.text = "残り時間" + TimeLeft + "秒";

        if (TimeLeft == 5)
        {
            StartCoroutine(countdown());
            Debug.Log("b");
        }
    }

    IEnumerator countdown ()
    {
        while (TimeLeft >= 0)
        {
            yield return new WaitForSeconds(1.0f);
            TimeLeft--;
        }
        Debug.Log("a");
    }
}
