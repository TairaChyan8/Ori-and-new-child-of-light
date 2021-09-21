using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{
    public int NeoTester;//це зміна цілих чисил
    public int DuoTester = 5;//ця зміна проініцілізована(надано значеня)
    private float _sireoTester = 3.4f;
    private float _guoTester;//Короче те що я не знаю

    public string FifiTester = "Ori its live";//  Короче де я можу писати
    private string _fufuTester;

    public char RTester = 'o';
    private char _pTester;

    public bool _suoTester = true;

    public GameObject ObjectTester;
 
    private void ALATEST()
    {
        if (FifiTester == "OriK" || FifiTester == "Ku")
        {
            Debug.Log("You with friend");
        }
        if (FifiTester == "AOK" && DuoTester < 5)
        {
            Debug.Log("OK");
        }
    }
    private void Update()//хунксія визивається один раз за кадром
    {
        ALATEST();
        GameHealt();
    }

    private void GameHealt()
    {
        if (NeoTester > 5)
        {
            Debug.Log("ERROR COMING");
           }
        else if (NeoTester < 5)
        {
            Debug.Log("ALL GOOD");
        }

        if (_suoTester == false)
        {
            Debug.Log("AHHAAHAHHAAHHAAHAH YOU FIND X)");
           }
        else 
        {
            Debug.Log("ALL GOOD");

        }
    }
}
