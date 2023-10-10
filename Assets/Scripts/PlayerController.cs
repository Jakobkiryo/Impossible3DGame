using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; // Field
    
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody.velocity.y < -.1f)
        {
            rigidbody.AddForce(0,-1,0);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isTochingGround()) 
        {
            
            Rigidbody rigidbody = gameObject
                .GetComponent<Rigidbody>();
            rigidbody.AddForce(0, 200, 0);
        }
        
        transform.Translate(0, 0, speed);
    }

    bool isTochingGround()
    {
        int layermask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, 
            transform.lossyScale / 1.99f,transform.rotation, layermask);
        
        return true;
    }
}
