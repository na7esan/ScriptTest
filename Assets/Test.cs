using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // マジックポイント

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 魔法攻撃用の関数
    public void MagicAttack()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } 
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }


    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}



public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;


        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素をすべて逆順で表示する
        for (int i = array.Length - 1 ; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        for(int i = 0; i < 11; i++)
        {
            lastboss.MagicAttack();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}