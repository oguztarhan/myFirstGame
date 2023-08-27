using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    
   [SerializeField] float moveSpeed=0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintThings();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintThings()
    {
        Debug.Log("CONNECTOPIA");
        Debug.Log("Play with 'WASD' ");
    }

    void MovePlayer()
    {
        float x=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float z=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(x,0,z);
    }
}


