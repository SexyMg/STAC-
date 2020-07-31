﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Text priceText;
    public GameObject Price;
    public int ColorIndex = 0;
    public GameObject lockImg;
    public void ColorChange()
    {
        if (BulletData.instance.isLockArray[ColorIndex] == 1)
        {
            BulletData.instance.currentColorIndex = ColorIndex;
            PlayerPrefs.SetInt(BulletData.instance.currentColorKey,ColorIndex);
        }
    }

    private void Update()
    {
        if (BulletData.instance.isLockArray[ColorIndex] == 0)
        {
            Price.SetActive(true);
            lockImg.SetActive(true);
        }
        else
        {
            Price.SetActive(false);
            lockImg.SetActive(false);   
        }
    }

    public void Unlock()
    {
        
        if (GoldManager.instance.isGold(int.Parse(priceText.text))) //골드가 있으면
        {
            GoldManager.instance.LoseGold(int.Parse(priceText.text));   
            BulletData.instance.Unlock(ColorIndex);
            ColorChange();
        }
        else
        {
            print("골드가 부족합니다!");
        }
    }
}
