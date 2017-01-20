using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    public string interactableNPCName;
    public bool end;
    // Use this for initialization
    void Start()
    {
        end = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (end)
            {
                SceneManager.LoadScene("lol3");
            }
        }
    }
    private void OnCollisionStay2D(Collision2D coll)
    {
        interactableNPCName = coll.gameObject.name;
        if(interactableNPCName=="indra")
        {
            end = true;
        }
    }
}