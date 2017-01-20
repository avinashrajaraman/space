using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class gameover : MonoBehaviour {

    public bool thund, indra;
	// Use this for initialization
	void Start ()
    {
        thund = true;
        indra = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(!GameObject.Find("thund") || !GameObject.Find("indra"))
        {
            SceneManager.LoadScene("lol6");
        }
	}
}
