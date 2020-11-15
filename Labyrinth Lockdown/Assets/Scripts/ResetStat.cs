using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStat : MonoBehaviour
{
    public FloatData moveSpeed, normalSpeed, jumpHeight;
    void Start()
    {
        moveSpeed.value = normalSpeed.value;
        jumpHeight.value = normalSpeed.value;
    }
}
