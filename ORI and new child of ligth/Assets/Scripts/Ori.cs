using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ori : MonoBehaviour
{
    public float Heals = 3;
    public bool GameObject = true;
    public float Energyk = 3;
     private void Grass()
    {
        if (Heals == 0 && GameObject == false)
        {
            Debug.Log("You die");
        }
        else 
        {
            Debug.Log("You live");
        }
    }
    private void Update()
    {
        Grass();
        Energy();
    }
    
    private void Energy()
    {
        if (Energyk <= 0)
        {
            Debug.Log("Need some crystal!");
        }
        else
        {
            Debug.Log("You are full of energy");
        }
        if (Energyk > 1 && Heals == 1)
        {
                Debug.Log("Use energy for hiling");
        }
    }

}
