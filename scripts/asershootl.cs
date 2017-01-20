using UnityEngine;
using System.Collections;

public class asershootl : MonoBehaviour {
    public GameObject laserbeam;
    public Transform laserspawn;
    public bool shoot,collide;
    public string interactableNPCName;
    public GameObject laser;
    // Use this for initialization
    void Start ()
    {
        collide = false;   
        /*laser = (GameObject)Instantiate(laserbeam, laserspawn.position, laserspawn.rotation);
        shoot = true;*/
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (collide)
        {
            if (Input.GetKeyDown(KeyCode.E))

            {
                laser = (GameObject)Instantiate(laserbeam, laserspawn.position, laserspawn.rotation);
                Destroy(laser,3.0f);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {

        interactableNPCName = coll.gameObject.name;
        if (interactableNPCName == "thund")
        {
            collide = true;
        }

    }
   



}
