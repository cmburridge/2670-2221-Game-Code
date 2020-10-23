using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;
using Slider = UnityEngine.UIElements.Slider;

public class DamageBehavior : MonoBehaviour
{
    public FloatData currentHealth;
    public FloatData maxHealth;
    public FloatData damageAmount;
    public UnityEngine.UI.Slider healthBar;
    
    void Start()
    {
        currentHealth.value = maxHealth.value;
        healthBar.value = maxHealth.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentHealth.value -= damageAmount.value;
        
    }

    private void Update()
    {
        if (currentHealth.value == 0)
        {
            Destroy(gameObject);
        }  
       
        healthBar.value = currentHealth.value;
    }
}
