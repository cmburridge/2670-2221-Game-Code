using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBehavior : MonoBehaviour
{
    public GameObject activatedObj;
    private void OnTriggerEnter(Collider other)
    {
        activatedObj.SetActive(true);
    }

    private void Start()
    {
        activatedObj.SetActive(false);
    }
}
