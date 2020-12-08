using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class PowerUpTracker : MonoBehaviour
{
    public BoolData keyCollected, speedCollected, jumpCollected, hpCollected;
    public GameObject keyImage, speedImage, jumpImage, hpImage;

    private void FixedUpdate()
    {
        if (keyCollected.isTrue == true)
        {
            Instantiate(keyImage);
        }

        if (speedCollected.isTrue == true)
        {
            Instantiate(speedImage);
        }
        
        if (jumpCollected.isTrue == true)
        {
            Instantiate(jumpImage);
        }
        
        if (hpCollected.isTrue == true)
        {
            Instantiate(hpImage);
        }
    }
}
