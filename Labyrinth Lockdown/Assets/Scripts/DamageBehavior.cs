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
    public GameObject damageScreen, deadPrefab1, deadPrefab2, deadPrefab3, deadPrefab4;
    
    public BoolData keyCollected, speedCollected, jumpCollected, hpCollected;

    private void Start()
    {
        if (currentHealth.value <= 0f)
        {
            currentHealth.value = maxHealth.value;
            gameObject.SetActive(true);
        }
        healthBar.fillAmount = currentHealth.value;
        
        damageScreen.SetActive(false);
    }

    public void HealthUpdate()
    {
        currentHealth.value = maxHealth.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherTag = other.CompareTag("Bullet");
        if (otherTag && canDamage == true)
        {
            damageScreen.SetActive(true);
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
        damageScreen.SetActive(false);
    }

    private void Update()
    {
        healthBar.fillAmount = currentHealth.value;
        
        if (currentHealth.value <= 0)
        {
            Instantiate(deadPrefab1, transform.position, Quaternion.identity);
            Instantiate(deadPrefab2, transform.position, Quaternion.identity);
            Instantiate(deadPrefab3, transform.position, Quaternion.identity);
            Instantiate(deadPrefab4, transform.position, Quaternion.identity);
            keyCollected.isTrue = false;
            speedCollected.isTrue = false;
            hpCollected.isTrue = false;
            jumpCollected.isTrue = false;
            deathCount.value += 1;
            canDamage = true;
            gameObject.SetActive(false);
        }
    }
}
