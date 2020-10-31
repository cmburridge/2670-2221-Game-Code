using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehavior : MonoBehaviour
{
   public float speed = 3f;
   public Transform objLocation;
   public bool enraged = false;
   public Animator enemyAnimate;
   public void LocatePlayer()
   {
      enraged = true;
   }

   public void LosePlayer()
   {
      enraged = false;
   }

   private void FixedUpdate()
   {
      if (enraged == true)
      {
         transform.LookAt(objLocation);
         transform.Translate(0,0,speed * Time.fixedDeltaTime);
         enemyAnimate.enabled = false;
      }
      else
      {
         enemyAnimate.enabled = true;
      }
   }
}
