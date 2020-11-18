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
        if (keyCollected.isTrue == true)
        {
            keyImage.SetActive(true);
        }

        if (speedCollected.isTrue == true)
        {
            speedImage.SetActive(true);
        }
        
        if (jumpCollected.isTrue == true)
        {
            jumpImage.SetActive(true);
        }
        
        if (hpCollected.isTrue == true)
        {
            hpImage.SetActive(true);
        }
    }
}
