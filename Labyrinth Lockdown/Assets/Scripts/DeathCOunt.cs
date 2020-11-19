using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCOunt : MonoBehaviour
{
    public FloatData deathAmount;
    public Text amount;
    
    private void Start()
    {
        amount.text = deathAmount.value.ToString();
    }

    public void FirstPrisoner()
    {
        if (deathAmount.value == 0)
        {
            deathAmount.value += 1;
        }
    }
}
