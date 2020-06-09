﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletData : MonoBehaviour
{
    public Color[] colors;
    public static BulletData instance;
    public float playerAroundValue; //플레이어 방향으로 직선 이동하는 동그라미가 인식하는 부분
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public Color SetColor(int index)
    {
        return colors[index];
    }
}
