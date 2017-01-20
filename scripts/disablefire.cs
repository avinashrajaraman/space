using UnityEngine;
using System.Collections;

public class disablefire : MonoBehaviour {

    // Use this for initialization
    public string interactableNPCName;
    public bool correct;
    void Start ()
    {
        correct = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(correct)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(GameObject.Find("flame"));
            }
        }
	}
    private void OnCollisionStay2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        if(interactableNPCName=="zeus")
        {
            correct = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        correct = false;
        /*if (interactableNPCName == "Indra")
        {
           
            //This call will close the last opened notification
            DialogueSystemManager.Instance.CloseNotification();
        }*/
    }
}
