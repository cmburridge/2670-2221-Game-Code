using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float delayTime = 1f;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(delayTime);
    }
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return waitObj;
        Destroy(gameObject);
    }
}
