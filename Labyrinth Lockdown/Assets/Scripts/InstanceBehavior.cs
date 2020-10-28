using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBehavior : MonoBehaviour
{
   public GameObject prefab;
   
   
   public void Instance()
   {
      var location = transform.position;
      var newObj = Instantiate(prefab, location,Quaternion.identity);
   }

   private void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         Instance();
      }
   }
}
