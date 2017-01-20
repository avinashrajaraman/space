using UnityEngine;
using System.Collections;

public class Playermobility : MonoBehaviour {
    public float speed = 5f;
    public Rigidbody2D rb;
    public bool down=false, up=false, left=false, right=false;
    public bool thor=false,zeus=false,indra=false,thund=false;
    // Use this for initialization

    Animator anim;
    void Start ()
    {
        anim=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
            if (Input.GetKey(KeyCode.D))
        {
            right = true;
             left = false;
             up = false;
             down = false;
            transform.Translate(Vector2.right * speed);
            anim.Play("thor_walkright");
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            right = false;
            left = true;
            up = false;
            down = false;
            transform.Translate(-Vector2.right * speed);
            anim.Play("thor_walkleft");
            //rb.AddForce(-Vector2.right * 2);
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            right = false;
            left = false;
            up = true;
            down = false;
            transform.Translate(Vector2.up * speed);
            anim.Play("thor_walkup");
            return;
        }
        if (Input.GetKey(KeyCode.S))
        {
            right = false;
            left = false;
            up = false;
            down = true;
            transform.Translate(-Vector2.up * speed);
            anim.Play("thor_walkdown");
            return;
        }
        else
        {   if (right == true)
            {
                anim.Play("thor_idleright");
            }
            else if (left == true)
            {
                anim.Play("thor_idleleft");
            }
            else if (up == true)
            {
                anim.Play("thor_idleup");
            }
            else
            {
                anim.Play("thor_idledown");
            }
        }
            

        


        
    }
  

}
