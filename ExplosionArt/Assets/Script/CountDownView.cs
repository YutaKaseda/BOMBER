using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownView : MonoBehaviour
{
    Text CountDounText;
    int Timer;

	// Use this for initialization
	void Start ()
    {
        CountDounText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        CountDounText.text = "爆発まで：" + Timer + "秒";
    }
}
