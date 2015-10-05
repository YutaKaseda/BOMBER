using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

	Vector2 fastMousePosition;
	Vector2 nowMousePosition;
	Vector2 lastMousePosition;
	Vector2 moveClick;
	Rigidbody2D rigBody2d;
	int bombTime;						// 爆発までの時間
	int bombFlg;						// ボムの状態 0.発射していない　1.発射している　2.爆発した
	GameObject bombEffect;				// ボムの爆発エフェクト


	// Use this for initialization
	void Start () {
		// エフェクトのロード
		bombEffect = Resources.Load ("Prefab/EffBomb") as GameObject;
		// fpsを60で固定
		Application.targetFrameRate = 60;
		rigBody2d = gameObject.AddComponent<Rigidbody2D> ();
		rigBody2d.isKinematic = true;

		bombTime = 300;
		bombFlg = 0;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {

			fastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//Debug.Log ("FMP "+fastMousePosition);
		}

		if (Input.GetMouseButton (0)) {
			nowMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			// マウスを動かしている時のみ移動させる
			if(Input.GetAxis("Mouse X") != 0 && Input.GetAxis("Mouse Y") != 0 ){
				moveClick =new Vector2 ((transform.position.x + (nowMousePosition.x - fastMousePosition.x)),(transform.position.y + (nowMousePosition.y - fastMousePosition.y)));
				transform.position = moveClick/2;
			}
			//Debug.Log ("NMP "+nowMousePosition);
		}
		if(Input.GetMouseButtonUp(0)){

			lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);		
			//Debug.Log ("LMP "+lastMousePosition);
			//Debug.Log ("FMP - LMP "+ (fastMousePosition - lastMousePosition));
			// ボム移動
			moveBomb ();

			// リセット
			fastMousePosition *= 0;
			nowMousePosition *= 0;
			lastMousePosition *= 0;

		}

		//ボム飛翔中
		if (bombFlg == 1) {
			Debug.Log ("position " + transform.position);
			Debug.Log ("bombTime " + bombTime);
			bombTime--;
		}
		// ボム爆散
		if (bombTime <= 0 && bombFlg != 2) {

			Debug.Log ("bomb!!");
			// ボム消去
			deleteBomb();
			bombFlg = 2;
		}
	}
	
	// ボム移動中の処理
	void moveBomb(){
		bombFlg = 1;
		rigBody2d.isKinematic = false;
		rigBody2d.AddForce ((fastMousePosition - lastMousePosition)*200);
		//Debug.Log ("FMP -LMP(moveBomb) " + (fastMousePosition - lastMousePosition));


	}

	// ボム消去時の処理
	void deleteBomb(){

		// 爆発エフェクト
		Instantiate (bombEffect,transform.position,transform.rotation);
		// ボムの消去
		Destroy (gameObject);
		// シーンの移動

	}
}
