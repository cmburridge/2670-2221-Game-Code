using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
   public Vector3 direction;
   public Transform enemyRotation;
   private Rigidbody rBody;
   public float force = -30f;

   void Start()
   {
      rBody = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      this.transform.rotation = enemyRotation.rotation;
      rBody.transform.Translate(0,0,-1);
   }
}