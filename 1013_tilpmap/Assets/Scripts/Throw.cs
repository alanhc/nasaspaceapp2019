using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Throw : MonoBehaviour
{
    Rigidbody rgb;
    void Start()
    {
        // 找到 Dice 的 Rigidbody 元件，用 rgb 代表
        rgb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 按空白鍵時
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 將 Trigger 關掉，用物理引擎處理
            GetComponent<BoxCollider>().isTrigger = false;
            // 移動骰子到中央位置
            transform.position = new Vector3(0f, 1.5f, 0f);
            // 以亂數產生往上的力量向量
            Vector3 force = new Vector3(0f, Random.Range(700f, 2000f), 0f);
            // 以亂數產生施力點，施力點不同可以產生不同的轉速與角度
            Vector3 pos = new Vector3(Random.Range(-8f, 10f), 0f, Random.Range(-8f, 10f));
            // 對骰子施力點的施力
            rgb.AddForceAtPosition(force, pos);
        }
    }
}
