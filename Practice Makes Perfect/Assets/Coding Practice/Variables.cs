using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int myHealth = 10;

    void Start()
    {
        myHealth = 50;
        Debug.Log("My health is " + myHealth);
    }

    
    
    void Update()
    {
        
    }
}
