using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Singleton<SoundPlayer>.instance.playSE("se004");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Singleton<SoundPlayer>.instance.playSE("se005");
        }
	}
}
