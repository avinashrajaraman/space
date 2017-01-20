using UnityEngine;
using System.Collections;
using System;

public class laser : MonoBehaviour {
    public string interactableNPCName;
    public bool hit;
    // Use this for initialization
    void Start ()
    {
        hit = false;
    }
	
	// Update is called once per frame
	void Update ()
    {

        transform.Translate(Vector2.left*0.1f);
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        if (interactableNPCName == "levelmap_0")
        {
            hit = true;
            Destroy(GameObject.Find("levelmap_0"));
        }

    }



}
