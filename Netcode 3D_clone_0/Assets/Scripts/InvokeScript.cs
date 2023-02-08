using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    [Header("Ball Stuff")]
    public GameObject target;
    public Transform parent;
    public float ballCooldown;

    void Start()
    {
        InvokeRepeating("SpawnObject", ballCooldown, 1);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        
        Instantiate (target, new Vector3(x, 2, z), Quaternion.identity, parent);
    }

}
