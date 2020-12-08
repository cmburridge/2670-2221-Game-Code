using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckDestroy : MonoBehaviour
{
    public BoolData status;
    
    void Update()
    {
        if (status.isTrue == false)
        {
            Destroy(this);
        }
    }
}
