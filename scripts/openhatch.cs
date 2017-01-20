using UnityEngine;
using System.Collections;

public class openhatch : MonoBehaviour {

    public string interactableNPCName;
    bool hit;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (hit)
            {
                Destroy(GameObject.Find("bulkhead-walls-pipes_4"));
            }
        }
	}
    private void OnCollisionEnter2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        if (interactableNPCName == "indra")
        {
            hit = true;
        }

    }
}
