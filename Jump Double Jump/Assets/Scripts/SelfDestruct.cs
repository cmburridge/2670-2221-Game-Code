using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
