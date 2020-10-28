using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehavior : MonoBehaviour
{
   public Transform lookedAtObj;

   private void FixedUpdate()
   {
      transform.LookAt(lookedAtObj);
   }
}
