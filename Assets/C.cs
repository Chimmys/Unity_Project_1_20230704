using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class C : MonoBehaviour
{
    float x = 0;
    int lv = 1;
    bool ��abool = false;
    Rigidbody2D rBody;
    public Animator Big;
    public GameObject ��a_super;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        Big = GetComponent<Animator>();
        GameObject gobj_super = ��a_super;
        int n = 1;
        float r = 0.1f;
        while (300 / r > n)
        {
            GameObject copy��a = Instantiate(gobj_super);
            copy��a.transform.parent = gobj_super.transform;
            copy��a.transform.localPosition = new Vector3(0.1f, 0, 0);
            copy��a.transform.localRotation = Quaternion.Euler(0, 0, r);
            copy��a.name = "��a_copy" + n;
            gobj_super = copy��a;

            n++;
        }
    }
    void Update()
    {

        x = Input.GetAxis("Horizontal") * Time.deltaTime * 200;

        if (Input.GetAxisRaw("Horizontal") == 1)
        {

            Big.enabled = true;
        }
        else
        {
            Big.enabled = false;
        }
        if (��abool && Input.GetAxisRaw("Jump") == 1)
        {
            ��abool = false;
            rBody.velocityY = 6;
        }
        rBody.velocityX += x;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "��a")
        {
            ��abool = true;
        }
    }
}
