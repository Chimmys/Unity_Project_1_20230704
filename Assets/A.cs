using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
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
    }
}
