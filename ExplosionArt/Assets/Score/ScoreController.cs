using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private Text scoreText;
    private float score;

    public void Start()  {//後でInitに書き換えてUIManager側からオブジェクト生成する！・・・したい。
        scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	private void Update ()  {
        score = GameObject.Find("DataManager").GetComponent<DataManager>().score;
        Debug.Log("現在のスコア" + score + "を取得したので表示");
        scoreText.text = score.ToString();

	}

}
