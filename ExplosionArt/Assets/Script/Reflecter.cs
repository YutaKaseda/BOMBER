using UnityEngine;
using System.Collections;

public class Reflecter : MonoBehaviour
{
    public Rigidbody2D rgid2D;
    public string gameTag;

	// Use this for initialization
	void Start ()
    {
        rgid2D = GetComponent<Rigidbody2D>();
	}
	
	void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("ボムがどの方向にあるかを求めるよ");
        Vector2 direction = transform.position - other.gameObject.transform.position;
        direction.Normalize();

        if (other.gameObject.tag == gameTag)
        {
            Debug.Log("ボムがぶつかったら反射させるよ");
            rgid2D.AddForce(direction);
        }
	}
}
