﻿using UnityEngine;
using System.Collections;

public class Thundmobility : MonoBehaviour {
    public float speed = 0.1f;
    public bool down = false, up = false, left = false, right = false;
    // Use this for initialization

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            right = true;
            left = false;
            up = false;
            down = false;
            transform.Translate(Vector2.right * speed);
            anim.Play("thund_walkright");
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            right = false;
            left = true;
            up = false;
            down = false;
            transform.Translate(-Vector2.right * speed);
            anim.Play("thund_walkleft");
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            right = false;
            left = false;
            up = true;
            down = false;
            transform.Translate(Vector2.up * speed);
            anim.Play("thund_walkup");
            return;
        }
        if (Input.GetKey(KeyCode.S))
        {
            right = false;
            left = false;
            up = false;
            down = true;
            transform.Translate(-Vector2.up * speed);
            anim.Play("thund_walkdown");
            return;
        }
        else
        {
            if (right == true)
            {
                anim.Play("thund_idleright");
            }
            else if (left == true)
            {
                anim.Play("thund_idleleft");
            }
            else if (up == true)
            {
                anim.Play("thund_idleup");
            }
            else
            {
                anim.Play("thund_idledown");
            }
        }






    }
}

