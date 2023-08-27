using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int x=0;
     void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
            x++;
            Debug.Log("Your score is: " + x);
        }
        
    }
}
