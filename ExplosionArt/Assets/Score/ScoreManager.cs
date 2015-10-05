using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public float score { get; private set; }
    private float scoreYard;

	// Use this for initialization
	private void Awake () {
        score = 0.0f;
        scoreYard = 0.0f;
	}

    private void Update(){

        if (scoreYard > 0)
        {
            score += 100;
            scoreYard -= 100;
        }

    }

    public void plusScore(float plus){
        Debug.Log(plus + "分スコア加算");
        scoreYard += plus;

    }

}
