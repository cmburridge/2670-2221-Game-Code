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

    private void Start()
    {
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

    public void RestartStats()
    {
        keyCollected.isTrue = false;
        speedCollected.isTrue = false;
        hpCollected.isTrue = false;
        jumpCollected.isTrue = false;
    }

    public void SpawnIcon()
    {
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

    public void SpawnKey()
    {
        if (keyCollected.isTrue == true)
        {
            Instantiate(keyImage);
        }
    }
}
