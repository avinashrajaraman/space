using UnityEngine;
using System.Collections;
using DialogueSystem;
using UnityEngine.SceneManagement;

public class decision : MonoBehaviour {
    public bool choice;
	// Use this for initialization
	void Start ()
    {
     
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //DialogueSystemManager.Instance.StartDialogueForNpc("loser");
            Application.Quit();

        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //DialogueSystemManager.Instance.StartDialogueForNpc("try again");
            SceneManager.LoadScene("lol");

        }
	}
}
