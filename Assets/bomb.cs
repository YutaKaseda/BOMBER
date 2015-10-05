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

	// Use this for initialization
	void Start () {
		rigBody2d = gameObject.AddComponent<Rigidbody2D> ();
		rigBody2d.isKinematic = true;

		bombTime = 600;
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
			moveBomb ();
			fastMousePosition *= 0;
			nowMousePosition *= 0;
			lastMousePosition *= 0;


		}
	
	}

	void moveBomb(){

		rigBody2d.isKinematic = false;
		rigBody2d.AddForce ((fastMousePosition - lastMousePosition)*200);
		Debug.Log ("FMP -LMP(moveBomb) " + (fastMousePosition - lastMousePosition));




	}


}
