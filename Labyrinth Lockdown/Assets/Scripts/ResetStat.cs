using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetStat : MonoBehaviour
{
    public FloatData moveSpeed, normalSpeed, jumpHeight, maxHealth, currentHealth;
    public BoolData keyCollected, speedCollected, jumpCollected, hpCollected;
    public GameObject keyImage, speedImage, jumpImage, hpImage;

    void OnTriggerEnter()
    {
        maxHealth.value = .66f;
        currentHealth.value = maxHealth.value;
        moveSpeed.value = normalSpeed.value;
        jumpHeight.value = normalSpeed.value;
        keyImage.SetActive(false);
        speedImage.SetActive(false);
        jumpImage.SetActive(false);
        hpImage.SetActive(false);
        keyCollected.isTrue = false;
        hpCollected.isTrue = false;
        speedCollected.isTrue = false;
        jumpCollected.isTrue = false;
    }
}
