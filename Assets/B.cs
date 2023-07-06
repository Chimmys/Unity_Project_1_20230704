using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class B : MonoBehaviour
{
    [SerializeField, Header("¸õÅD°ª«×"), Range(0, 3000)]
    private float heightjump = 350;
    [SerializeField, Header("ÀË¬d¦aªO¤Ø¤o")]

    
    private Animation ani;
    private Rigidbody2D rig;
    private bool clickjump;
    private void Awake()
    {
        ani = GetComponent<Animation>();
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        JumpKey();
    }
    private void FixedUpdate()
    {
        JumpForce();
    }
    private void JumpKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("¸õÅD");
            clickjump = true;
        }
    }
    private void JumpForce()
    {
        if (!clickjump)
        {
            rig.AddForce(new Vector2(0, heightjump));
            clickjump = false;
        }
    }
}
