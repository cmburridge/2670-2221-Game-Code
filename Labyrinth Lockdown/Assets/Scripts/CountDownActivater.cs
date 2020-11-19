using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownActivater : MonoBehaviour
{
    public GameObject activatedObj;
    public GameObject activaterObj;
    public bool isActive = false;
    public bool timerRunning = false;
    public FloatData timer;
    public Text countDown;
    private void OnTriggerEnter(Collider other)
    {
        if (isActive == false)
        {
            activatedObj.SetActive(true);
            activaterObj.SetActive(false);
            isActive = true;
            timerRunning = true;
            timer.value = 30;
        }
    }
    private void Start()
    {
        activatedObj.SetActive(false);
        activaterObj.SetActive(true);
    }
    
    private void Update()
    {
        countDown.text = timer.value.ToString();
        
        if (timerRunning == true)
        {
            timer.value -= 1 * Time.deltaTime;   
        }

        if (timer.value <= 0)
        {
            activatedObj.SetActive(false);
            activaterObj.SetActive(true);
            isActive = false;
            timerRunning = false;
        }
    }
}
