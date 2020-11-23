using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerBehavior : MonoBehaviour
{ 
    public static bool gameIsPaused = false;
    public BoolData playerIsDead;
    public GameObject pauseMenuUi;
    public GameObject deathScreenUI;
    public FloatData currentHealth;

    private void Start()
    {
        playerIsDead.isTrue = false;
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    void Update () 
    {
        if (currentHealth.value <= 0)
        {
            deathScreenUI.SetActive(true);
            playerIsDead.isTrue = true;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (playerIsDead.isTrue == false)
            {
               if (gameIsPaused)
               {
                   Resume();
               }
               else
               {
                   Pause();
               }  
            }
        }
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
