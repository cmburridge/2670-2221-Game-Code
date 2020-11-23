using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;
using Image = UnityEngine.UIElements.Image;
using Slider = UnityEngine.UIElements.Slider;

public class DamageBehavior : MonoBehaviour
{
    public FloatData currentHealth;
    public FloatData maxHealth;
    public FloatData damageAmount;
    public FloatData deathCount;
    public UnityEngine.UI.Image healthBar;
    public bool canDamage = true;

    private void Start()
    {
        if (currentHealth.value <= 0f)
        {
            currentHealth.value = maxHealth.value;
            gameObject.SetActive(true);
        }
        healthBar.fillAmount = currentHealth.value;
    }

    public void HealthUpdate()
    {
        healthBar.fillAmount = maxHealth.value;
        currentHealth.value = maxHealth.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherTag = other.CompareTag("Bullet");
        if (otherTag && canDamage == true)
        {
          currentHealth.value -= damageAmount.value;
          healthBar.fillAmount -= damageAmount.value;
          StartCoroutine("InvulnTimer");
          canDamage = false;
        }
    }

    public IEnumerator InvulnTimer()
    {
        yield return new WaitForSeconds(2);
        canDamage = true;
    }

    private void Update()
    {
        if (currentHealth.value <= 0)
        {
            deathCount.value += 1;
            canDamage = true;
            gameObject.SetActive(false);
        }
    }
}
