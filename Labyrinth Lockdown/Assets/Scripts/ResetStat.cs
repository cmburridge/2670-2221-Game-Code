using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetStat : MonoBehaviour
{
    public FloatData moveSpeed, normalSpeed, jumpHeight, maxHealth, currentHealth;

    void OnTriggerEnter()
    {
        maxHealth.value = .66f;
        currentHealth.value = maxHealth.value;
        moveSpeed.value = normalSpeed.value;
        jumpHeight.value = normalSpeed.value;
    }
}
