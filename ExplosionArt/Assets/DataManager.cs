using UnityEngine;
using System.Collections;

public class DataManager : MonoBehaviour {

    public float score { get;  set; }

	// Use this for initialization
	private void Awake () {
        score = 0.0f;
	}

    public void plusScore(float plus){
        Debug.Log(plus + "分スコア加算");
        score += plus;
    }

}
