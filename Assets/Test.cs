using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;//int型の変数mpを宣言し、53で初期化する

    //mpを消費して、魔法攻撃をするMagic関数
    public void Magic()
    {
        //条件文：mpは5以上の場合、
        if (mp >= 5)
        {
            //mpを5減らす
            this.mp -= 5;

            //コンソールに”魔法攻撃をした”＋残りのmp値を表示
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            //mp5以下の場合、コンソールに"MPが足りないため、魔法が使えない"を表示
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }

}


public class Test : MonoBehaviour
{
    void Start()
    {
        //要素数5個、int型の配列を初期化する
        int[] Array = { 1, 2, 3, 4, 5 };

        //for文で、配列の要素数のぶんだけ、順番に処理を繰り返す
        for (int i = 0; i < Array.Length; i++)
        {
            //配列の要素を表示する（順番）
            Debug.Log(Array[i]);
        }


        //for文で、配列の要素数のぶんだけ、逆順番に処理を繰り返す
        for (int i = Array.Length - 1; i >= 0; i--)
        {
            //配列の要素を表示する（逆順番）
            Debug.Log(Array[i]);
        }

        //Bossクラスの変数を宣言して、インスタンスを代入
        Boss boss = new Boss();

        //for文で、10回処理を繰り返す
        for (int i = 0; i < 10; i++)
        {
            //Magic関数を呼び出す
            boss.Magic();
        }

        boss.Magic();
    }
}
