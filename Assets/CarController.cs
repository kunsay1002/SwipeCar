﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))            // マウスがクリックされたら
        {
            this.speed = 0.2f;                    // 初速度を設定
        }
        transform.Translate(this.speed, 0, 0);   // 移動
        this.speed *= 0.98f;                     // 減速
    } 
}
