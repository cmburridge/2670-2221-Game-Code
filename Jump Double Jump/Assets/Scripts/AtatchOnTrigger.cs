﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtatchOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var otherTag = other.CompareTag("Platform");
        if (otherTag)
        {
            transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
