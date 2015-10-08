using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    const int ExplosionTime = 6;

    int TimeLeft = ExplosionTime;
    public Text CountDounText;

    void Start()
    {
        CountDounText = GetComponent<Text>();
    }

    public void Action()
    {
        CountDounText.text = "爆発まで：" + TimeLeft + "秒";
        StartCoroutine(countdown());
    }

    IEnumerator countdown ()
    {
        Debug.Log("カウントダウン開始");

        while (TimeLeft > 0)
        {
            TimeLeft--;
            yield return new WaitForSeconds(1.0f);
        }
        Debug.Log("カウントダウン終了");
    }
}
