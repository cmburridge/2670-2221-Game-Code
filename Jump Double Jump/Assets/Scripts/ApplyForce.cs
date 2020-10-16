using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
   public float velocity = 10f;
   public Vector3 aim;

   private void FixedUpdate()
   {
      transform.Translate(aim);
   }
}
