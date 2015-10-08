using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    const int ExplosionTime = 6;

    Text CountDownTaxt;
    int TimeLeft = ExplosionTime;

    void Start()
    {
        CountDownTaxt = GetComponent<Text>();
    }

    void Update()
    {
        CountDownTaxt.text = "爆発まで：" + TimeLeft + "秒";

        if (TimeLeft == ExplosionTime)
        {
            Debug.Log("カウントダウン開始");
            StartCoroutine(countdown());
        }
    }

    IEnumerator countdown ()
    {
        while (TimeLeft > 0)
        {
            TimeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
        Debug.Log("カウントダウン終了");
    }
}
