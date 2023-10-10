using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; // Field
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")) 
        {
            
            Rigidbody rigidbody = gameObject
                .GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 200, 0);
        }
        
        transform.Translate(0, 0, speed);
    }
}
