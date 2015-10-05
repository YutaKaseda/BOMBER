using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject EffectPrefab;
    public string Tag = "";

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == Tag)
        {
            Debug.Log("オブジェクト破壊");
            Destroy(other.gameObject);

            if (EffectPrefab != null)
            {
                Debug.Log("爆発エフェクト作るよ");
                Instantiate(
                    EffectPrefab,
                    other.transform.position,
                    Quaternion.identity
                    );
            }
        }
    }
}
