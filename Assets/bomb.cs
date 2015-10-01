using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

	Vector2 fastMousePosition;
	Vector2 nowMousePosition;
	Vector2 lastMousePosition;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			fastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log ("FMP "+fastMousePosition);
		}

		if (Input.GetMouseButton (0)) {
			nowMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = nowMousePosition;
			Debug.Log ("NMP "+nowMousePosition);
		}
		if(Input.GetMouseButtonUp(0)){

			lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);		
			Debug.Log ("LMP "+lastMousePosition);

		}
	
	}




}
