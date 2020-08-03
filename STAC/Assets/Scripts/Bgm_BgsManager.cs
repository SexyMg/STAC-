﻿using UnityEngine;
using UnityEngine.UI;

public class Bgm_BgsManager : MonoBehaviour
{
    public GameObject[] BGMvolumes;
    public GameObject[] SEvolumes;
    private int BGMIndex,SEIndex;
    private AudioSource bgm;
    void Start()
    {
        BGMIndex = (int)(SoundMgr.instance.savedBgm / 0.33f);
        SEIndex = (int)(SoundMgr.instance.savedSE / 0.33f);
        bgm = FindObjectOfType<BGM>().GetComponent<AudioSource>();
        for (int i = 0; i < BGMvolumes.Length; i++)
        {
            if (i < BGMIndex)
                BGMvolumes[i].SetActive(true);
            else
                BGMvolumes[i].SetActive(false);
        }
        for (int i = 0; i < SEvolumes.Length; i++)
        {
            if (i < SEIndex)
                SEvolumes[i].SetActive(true);
            else
                SEvolumes[i].SetActive(false);
        }
    }

    public void BGMUp()
    {
        if (BGMIndex != BGMvolumes.Length)
            BGMIndex++;
        else
            BGMIndex=0;
        for (int i = 0; i < BGMvolumes.Length; i++)
        {
            if (i < BGMIndex)
                BGMvolumes[i].SetActive(true);
            else
                BGMvolumes[i].SetActive(false);
        }
        SoundMgr.instance.bgmValue(0.33f*BGMIndex);
        bgm.volume = 0.33f * BGMIndex;
    }
    public void SEUp()
    {
        if (SEIndex != SEvolumes.Length)
            SEIndex++;
        else
            SEIndex=0;
        for (int i = 0; i < SEvolumes.Length; i++)
        {
            if (i < SEIndex)
                SEvolumes[i].SetActive(true);
            else
                SEvolumes[i].SetActive(false);
        }
        SoundMgr.instance.seValue(0.33f*SEIndex);
    }
}
