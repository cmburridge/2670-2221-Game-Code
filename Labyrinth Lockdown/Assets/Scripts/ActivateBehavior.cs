using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBehavior : MonoBehaviour
{
    public GameObject activatedObj;
    public GameObject activaterObj;
    public bool isActive = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isActive == false)
        {
            activatedObj.SetActive(true);
            activaterObj.SetActive(false);
            isActive = true;
        }
        else
        {
            activatedObj.SetActive(false);
            activaterObj.SetActive(true);
            isActive = false;
        }
    }

    private void Start()
    {
        activatedObj.SetActive(false);
        activaterObj.SetActive(true);
    }
}
