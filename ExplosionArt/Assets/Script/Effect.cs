using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour
{
    ParticleSystem effect;

	// Use this for initialization
	void Start ()
    {
        effect = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("爆発のエフェクト消滅");
        if (effect.isPlaying == false) Destroy(gameObject);
	}
}
