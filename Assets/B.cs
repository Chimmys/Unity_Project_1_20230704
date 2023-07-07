using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class B : MonoBehaviour
{
    [SerializeField, Header("跳躍高度"), Range(0, 3000)]
    private float heightJump = 350;
    [SerializeField, Header("檢查地板尺寸")]
    private Vector3 v3CheckGroundSize = Vector3.one;
    [SerializeField, Header("檢查地板位移")]
    private Vector3 v3CheckGroundOffset;
    [SerializeField, Header("檢查地板顏色")]
    private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
    [SerializeField, Header("檢查地板圖層")]
    private LayerMask layerCheckGround;
    private Animation ani;
    private Rigidbody2D rig;
    private bool clickjump;
    private bool isGround;

    private void OnDrawGizmos()
    {
        Gizmos.color = colorCheckGround;
        Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
    }
    private void Awake()
    {
        ani = GetComponent<Animation>();
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        JumpKey();
        CheckGround();
    }
    private void FixedUpdate()
    {
        JumpForce();
    }
    private void JumpKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("跳躍");
            clickjump = true;
        }
    }
    private void JumpForce()
    {
        if (clickjump && isGround)
        {
            rig.AddForce(new Vector2(0, heightJump));
            clickjump = false;
        }
    }
    private void CheckGround()
    {
        //Collision2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
        //print("碰到的物件 : "+hit.name);
        //isGround = hit;
    }
}
