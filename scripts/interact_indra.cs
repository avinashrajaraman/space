using UnityEngine;
using System.Collections;

public class interact_indra : MonoBehaviour {

    // public bool thund,zeus; 
    public bool indra;
    public float health;
    public string interactableNPCName;
    public AudioSource DeathAudio;
    // Use this for initialization
    void Start()
    {
        health = 100;
        // thund = false;
        indra = false;
        // zeus = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (indra)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Used to start a dialogue conversation. Pass in the name of the starter you set for the conversation
                
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (interactableNPCName == "killer_box")
        {
            DeathAudio.Play();
            Destroy(GameObject.Find("indra"),0.6f);
           

        }
        if (interactableNPCName == "flame")
        {
            DeathAudio.Play();
            Destroy(GameObject.Find("indra"),0.6f);
        }

    }



    private void OnCollisionStay2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        indra = true;
       
        

    }
    private void OnCollisionExit2D(Collision2D col)
    {
        indra = false;
        /*if (interactableNPCName == "Indra")
        {
           
            //This call will close the last opened notification
            DialogueSystemManager.Instance.CloseNotification();
        }*/
    }
}
