using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool isTrue;

    public void UpdateBool(bool isTrue)
    {
        isTrue = true;
    }
}
