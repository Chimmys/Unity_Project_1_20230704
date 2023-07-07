using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
   // public Rigidbody2D rb;
   // public float speed;
   // public float jumpforce;
    float x=-32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         x += Input.GetAxis("Horizontal") * Time.deltaTime * 10;
         transform.position = new Vector2(x,-140);
        

        //movement();
     }
     /*void movement()
     {
         
         float horizontalmove = Input.GetAxis("Horizontal");
         float facedircetion = Input.GetAxisRaw("Horizontal");

        if (horizontalmove != 0)
         {
             rb.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, rb.velocity.y);
         }
        if (facedircetion != 0) 
        {
            rb.velocity = new Vector3(facedircetion, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x , jumpforce * Time.deltaTime);
        }
    }*/
}
