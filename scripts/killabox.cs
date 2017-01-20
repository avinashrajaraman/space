using UnityEngine;
using System.Collections;

public class killabox : MonoBehaviour {
    public float speed = 0.1f;
    private Vector2 startPosition;
    public float maxheight;
    public float minheight;
    bool  down = true;
    //public float waitTime = 100f;
    //float timer=0;
    // Use this for initialization
    void Start ()
    {
        startPosition = transform.position;
        minheight = startPosition.y;
        maxheight = minheight - 8;
    }

    // Update is called once per frame
    void Update()
    {

        //timer += Time.deltaTime;
        //if (timer >= waitTime)
        //{
        if (down)
        {
            transform.Translate(Vector2.down * speed);
            if (transform.position.y <= 118)
            {
                down = false;
            }
        }
        else
        {
            transform.Translate(Vector2.up * speed);
            if (transform.position.y >= 126)
                down = true;

        }

        //}
    }
}
