using UnityEngine;
using System.Collections;

//------------------------------------------------------
//ボムに適用するCollision判定クラス
//作成者:悴田 悠太
//作成日:20151001
//更新履歴
//・20151001 作成
//------------------------------------------------------

public class BombCollision : MonoBehaviour
{
    //Collision先に命令を送るよ
    void OnCollisionEnter2D(Collision2D col)
    {
        //処理の可視化
        Debug.Log("タグ:" + col.gameObject.tag + "の名前:" + col.gameObject.name + "に当たりました");

        //接触先のタグで命令判断
        switch (col.gameObject.tag){

            case "NormalObject":    //箱、樽
                col.gameObject.GetComponent<NormalObjectCollision>().collisionMethod();
                Debug.Log("NormalObjectのcollisionMethodを呼び出します");
                break;

            default:                //処理が追加されていないとき
                Debug.Log("処理がありません");
                break;
        }

    }
}
