using UnityEngine;
using System.Collections;
using DialogueSystem;
using UnityEngine.SceneManagement;




public class Interaction : MonoBehaviour {
    public bool thund, indra, zeus, inInteractRange;
    public string interactableNPCName;
    public AudioSource DeathAudio;
   
    // Use this for initialization
    void Start ()
    {
        thund = false;
        indra = false;
        zeus = false;
        DialogueSystemManager.Instance.CloseNotification();
        //Destroy(DialogueSystemGUI.Instance);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!DialogueSystemManager.Instance.DialogueSystemIsActive())
        { if (inInteractRange)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //Used to start a dialogue conversation. Pass in the name of the starter you set for the conversation
                    DialogueSystemManager.Instance.StartDialogueForNpc(interactableNPCName);
                }
            }
            if (!GameObject.Find("indra"))
            {
                DialogueSystemManager.Instance.StartDialogueForNpc("indra1");

            }
            if (!GameObject.Find("zeus"))
            {
                DialogueSystemManager.Instance.StartDialogueForNpc("zeus1");
            }
            if (!GameObject.Find("thund"))
            {
                DialogueSystemManager.Instance.StartDialogueForNpc("thund1");
            }

        }
    }
private void OnCollisionEnter2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        inInteractRange = true;
        Debug.Log(interactableNPCName);
        if (interactableNPCName == "killer_box")
        {
            /*DeathAudio.Play();
            Destroy(GameObject.Find("thor"),0.6f);*/
            
        }
        
        if (interactableNPCName == "killer_box")
        {
            /*DeathAudio.Play();
            Destroy(GameObject.Find("thor"),0.6f);*/

        }
        if (interactableNPCName == "flame")
        {
            DeathAudio.Play();
            Destroy(GameObject.Find("thor"),0.6f);
        }
    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        inInteractRange = true;
        //DialogueSystemManager.Instance.OpenNotification(interactableNPCName);
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        inInteractRange = false;

        if (interactableNPCName == "indra")
        {
           
            //This call will close the last opened notification
            //DialogueSystemManager.Instance.CloseNotification();
        }
    }
}
