﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sicle : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("I playING");
    }
    public void Sleep()
    {
        Debug.Log("Im sleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeep");
    }
    public void Eat()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAA KUSHATS");

    }
    public void Study()
    {
        Debug.Log("I in SCHOOOOOlll NoOoO");
    }
    public string GetDay(int i)
    {
        var result = "ChO";
        if (i == 1)
        {
            result = "ponedilok";
        }
        else if (i == 2)
        {
            result = "vivtorok";
        }
        else if (i == 3)
        {
            result = "seredaa";
        }
        else if (i == 4)
        {
            result = "chetverg";
        }
        else if (i == 5)
        {
            result = "pyatnusa";
        }
        else if (i == 6)
        {
            result = "cubota";
        }
        else if (i == 7)
        {
            result = "nedila";
        }
        return result;
    }
    [ContextMenu("start")]
    public void ForLoop()
    {
        //int i=1    короче визде і ето что ми поставим после =
        //i <= 7     короче наш і будет отшитоватсадо той цифри которою ми поставим поси =
        //i++        короче к нашому і будет плюсоватса то ще самий і
        for (int i=1; i <= 7; i++)
        {
            Debug.Log($"Today is {GetDay(i)}");
            Eat();
            Play();
            Eat();
            if (i <= 5 && i >= 1)
            {
                Study();
            }
            else
            {
                Play();
            }
            Eat();
            Sleep();
        }
        
    }
}
 