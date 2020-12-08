using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInstantiate : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject powerController;
    
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }
}
