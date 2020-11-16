using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetStat : MonoBehaviour
{
    public FloatData moveSpeed, normalSpeed, jumpHeight, maxHealth, currentHealth;

    void OnTriggerEnter()
    {
        moveSpeed.value = normalSpeed.value;
        jumpHeight.value = normalSpeed.value;
        currentHealth.value = maxHealth.value;
    }
}
