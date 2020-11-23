using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetStat : MonoBehaviour
{
    public FloatData moveSpeed, normalSpeed, jumpHeight, maxHealth, currentHealth;
    public BoolData keyCollected, speedCollected, jumpCollected, hpCollected;
    public GameObject keyImage, speedImage, jumpImage, hpImage;
    public GameObject dialogue;
    private static bool gameIsPaused = false;
    public Text text;
    public string npcDialogue;
    
    void OnTriggerEnter()
    {
        maxHealth.value = .66f;
        currentHealth.value = maxHealth.value;
        moveSpeed.value = normalSpeed.value;
        jumpHeight.value = 2;
        keyImage.SetActive(false);
        speedImage.SetActive(false);
        jumpImage.SetActive(false);
        hpImage.SetActive(false);
        keyCollected.isTrue = false;
        hpCollected.isTrue = false;
        speedCollected.isTrue = false;
        jumpCollected.isTrue = false;
        StartingDialogue();
    }

    public void StartingDialogue()
    {
        dialogue.SetActive(true);
        text.text = npcDialogue;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
