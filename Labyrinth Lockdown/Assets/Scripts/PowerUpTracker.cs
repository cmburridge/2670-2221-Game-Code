using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class PowerUpTracker : MonoBehaviour
{
    public BoolData keyCollected, speedCollected, jumpCollected, hpCollected, secret;
    public GameObject keyImage, speedImage, jumpImage, hpImage, secretImage;

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
        
        if (secret.isTrue == true)
        {
            Instantiate(secretImage);
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
        
        if (secret.isTrue == true)
        {
            Instantiate(secretImage);
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
