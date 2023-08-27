using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{ 
    MeshRenderer renderer;
    Rigidbody rigidBody;
   [SerializeField] float timeToDrop = 3f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time  > timeToDrop)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
        
    }
}
