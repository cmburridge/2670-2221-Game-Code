using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBehavior : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Scene 1");
    }
}
