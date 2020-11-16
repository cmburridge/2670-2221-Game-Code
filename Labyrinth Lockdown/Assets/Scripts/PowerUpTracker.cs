using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTracker : MonoBehaviour
{
    public BoolData collected;
    public Image image;

    private void Update()
    {
        if (collected == true)
        {
            image.enabled = true;
        }
    }
}
