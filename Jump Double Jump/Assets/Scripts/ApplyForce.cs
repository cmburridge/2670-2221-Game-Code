using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
   private Rigidbody rBody;
   public float force = 30f;
   public Transform playerDirection;
   void Start()
   {
      rBody = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      rBody.AddForce(playerDirection.forward.normalized * force);
   }
}
