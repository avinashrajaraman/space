using UnityEngine;
using System.Collections;

public class interact_thund : MonoBehaviour {

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

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (interactableNPCName == "killer_box")
        {
            DeathAudio.Play();
            Destroy(GameObject.Find("thund"),0.6f);
           
        }
        if (interactableNPCName == "flame")
        {
            DeathAudio.Play();
            Destroy(GameObject.Find("thund"),0.6f);
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
