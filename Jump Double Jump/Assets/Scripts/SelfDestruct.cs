using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    void Update()
    {
        objDestroy();
    }
    
    private IEnumerator objDestroy()
    {
        yield return new WaitForSeconds(6f);
        Destroy(this);
    }
}
