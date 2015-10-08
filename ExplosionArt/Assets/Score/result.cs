using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class result : MonoBehaviour {

	float movedPosition;
	//int state;
	enum StateFlg{
		STOP = 1,
		MOVE,
		MOVEEND
	};

	[SerializeField]
	int stateFlg;

	GameObject bombEffect;				// ボムの爆発エフェクト
	GameObject scoreText;				// スコアGameObjectへのアクセス

	// Use this for initialization
	void Start () {
		movedPosition = 12;
		stateFlg = (int)StateFlg.STOP;
		scoreText = GameObject.Find ("ScoreText");
		bombEffect = Resources.Load ("Prefab/EffBomb") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("stateFlg " + stateFlg);

		switch (stateFlg) {
		case (int)StateFlg.MOVE:
			scoreText.active = false;
			if (transform.position.y >= movedPosition) {
				Debug.Log ("transform.position.y " + transform.position.y);
				transform.position -= new Vector3 (0, 3, 0);
			} else {
				stateFlg = (int)StateFlg.MOVEEND;			
			}
			break;
		case (int)StateFlg.MOVEEND:
			Debug.Log ("moveEnd");
			scoreText.transform.localPosition = new Vector3 (-11.0f,-35.0f,0.0f);
			scoreText.active = true;
			// 爆発エフェクト
			Instantiate (bombEffect,(transform.position - new Vector3(0,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-5,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-10,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-15,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-20,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-25,0,0)),transform.rotation);
			Instantiate (bombEffect,(transform.position - new Vector3(-30,0,0)),transform.rotation);
			stateFlg = 0;
			break;
		}
	}
	
	

}
