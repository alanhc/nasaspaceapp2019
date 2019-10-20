using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        transform.LookAt(target.transform);
    }
    void Update()
    {
        // 骰子離地較遠，像機跟隨骰子；接近地面，像機定點看骰子翻滾
        if (target.transform.position.y > 2f)
            transform.LookAt(target.transform);
    }
}
