using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBehavior : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public Text text;
    public string npcDialogue;
    
    public void Talking()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    
    public void EndTalk()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void ChangeDialogue()
    {
        text.text = npcDialogue;
    }
}
