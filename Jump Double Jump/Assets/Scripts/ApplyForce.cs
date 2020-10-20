using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
   private Rigidbody rBody;
   public float force = -30f;
   void Start()
   {
      rBody = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      rBody.AddForce(transform.forward * force);
   }
}
