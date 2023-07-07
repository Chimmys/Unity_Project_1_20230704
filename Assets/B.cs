using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class B : MonoBehaviour
{
    [SerializeField, Header("���D����"), Range(0, 3000)]
    private float heightJump = 350;
    [SerializeField, Header("�ˬd�a�O�ؤo")]
    private Vector3 v3CheckGroundSize = Vector3.one;
    [SerializeField, Header("�ˬd�a�O�첾")]
    private Vector3 v3CheckGroundOffset;
    [SerializeField, Header("�ˬd�a�O�C��")]
    private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
    [SerializeField, Header("�ˬd�a�O�ϼh")]
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
            print("���D");
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
        //print("�I�쪺���� : "+hit.name);
        //isGround = hit;
    }
}
