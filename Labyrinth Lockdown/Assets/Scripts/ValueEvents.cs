using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueEvents : MonoBehaviour
{
   public FloatData objValue;
   public float newValue;
   
   public void AddValue()
   {
      objValue.value += newValue;
   }

   public void SubtractValue()
   {
      objValue.value -= newValue;
   }
}
