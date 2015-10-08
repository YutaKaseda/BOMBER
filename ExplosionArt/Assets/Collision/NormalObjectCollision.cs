using UnityEngine;
using System.Collections;

//------------------------------------------------------
//NormalObjectタグの付いたオブジェクトに適用するCollision判定クラス
//作成者:悴田 悠太
//作成日:20151001
//更新履歴
//・20151001 作成
//------------------------------------------------------
public class NormalObjectCollision : MonoBehaviour {

    GameObject bombEffect;

    void Awake()
    {
        bombEffect = Resources.Load("Prefab/EffBomb") as GameObject;
    }

    //BombCollisionから発行
    public void collisionMethod()
    {

        Debug.Log("DataManagerにアクセスしてスコアを加算");
        GameObject.Find("DataManager").GetComponent<ScoreManager>().plusScore(10000.0f);
        // 爆発エフェクト
        Instantiate(bombEffect, transform.position, transform.rotation);
        Singleton<SoundPlayer>.instance.playSE("ObjectBreak");

        Debug.Log("objectDestroyメソッドを呼び出します");
        //破壊される処理、暫定的にオブジェクトを消す処理を記述
        objectDestroy();
    }

    //消します
    void objectDestroy()
    {
        Debug.Log("Destroyメソッドを呼び出し、オブジェクトを消します");
        Destroy(gameObject);
    }

}
