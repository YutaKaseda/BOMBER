using UnityEngine;
using System.Collections;

public class Barrier : MonoBehaviour
{
    bool StealthWall = false;
    public GameObject Bomb;
    public Collider2D barrier;

    void Start()
    {
        Bomb = GetComponent<GameObject>();
        barrier = GetComponent<BoxCollider2D>();
    }

	void OnTriggerEnter2D(Collider2D Bomb)
    {
        if (Bomb.gameObject.tag == "Bomb")
        {
            Debug.Log("ボムが接触したら真にするよ");
            StealthWall = true;
        }
    }

    void OnTriggerExit2D()
    {
        if (StealthWall)
        {
            Debug.Log("isTriggerを偽にするよ");
            barrier.isTrigger = false;
        }
    }
}
