using UnityEngine;
using System.Collections;

public class Characterselect : MonoBehaviour {
    GameObject zeus, thor;
  

	// Use this for initialization
	void Start ()
    {
        GameObject.Find("thor").GetComponent<Playermobility>().enabled = true;
        GameObject.Find("zeus").GetComponent<Zeusmobility>().enabled = false;
        GameObject.Find("indra").GetComponent<Indramobility>().enabled = false;
        GameObject.Find("thund").GetComponent<Thundmobility>().enabled = false;
        
        GameObject.Find("thor").GetComponent<Camera>().enabled= true;
        GameObject.Find("zeus").GetComponent<Camera>().enabled = false;
        GameObject.Find("indra").GetComponent<Camera>().enabled = false;
        GameObject.Find("thund").GetComponent<Camera>().enabled = false;

        Camera Thor= GameObject.Find("thor").GetComponent<Camera>();
        Camera Zeus = GameObject.Find("thor").GetComponent<Camera>();
        Camera Indra = GameObject.Find("thor").GetComponent<Camera>();
        Camera Thund = GameObject.Find("thor").GetComponent<Camera>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (GameObject.Find("zeus")) GameObject.Find("zeus").GetComponent<Zeusmobility>().enabled = false;
            if (GameObject.Find("thor")) GameObject.Find("thor").GetComponent<Playermobility>().enabled = true;
            if (GameObject.Find("indra")) GameObject.Find("indra").GetComponent<Indramobility>().enabled = false;
            if (GameObject.Find("thund")) GameObject.Find("thund").GetComponent<Thundmobility>().enabled = false;
            /*GameObject.Find("thor").GetComponent<Camera>().enabled = true;
            GameObject.Find("zeus").GetComponent<Camera>().enabled = false;
            GameObject.Find("indra").GetComponent<Camera>().enabled = false;
            GameObject.Find("thund").GetComponent<Camera>().enabled = false;*/
           
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if(GameObject.Find("zeus")) GameObject.Find("zeus").GetComponent<Zeusmobility>().enabled = true;
            if (GameObject.Find("thor")) GameObject.Find("thor").GetComponent<Playermobility>().enabled = false;
            if (GameObject.Find("indra")) GameObject.Find("indra").GetComponent<Indramobility>().enabled = false;
            if (GameObject.Find("thund")) GameObject.Find("thund").GetComponent<Thundmobility>().enabled = false;
            /*GameObject.Find("thor").GetComponent<Camera>().enabled = false;
            GameObject.Find("zeus").GetComponent<Camera>().enabled = true;
            GameObject.Find("indra").GetComponent<Camera>().enabled = false;
            GameObject.Find("thund").GetComponent<Camera>().enabled = false;*/
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (GameObject.Find("zeus")) GameObject.Find("zeus").GetComponent<Zeusmobility>().enabled = false;
            if (GameObject.Find("thor")) GameObject.Find("thor").GetComponent<Playermobility>().enabled = false;
            if (GameObject.Find("indra")) GameObject.Find("indra").GetComponent<Indramobility>().enabled = true;
            if (GameObject.Find("thund")) GameObject.Find("thund").GetComponent<Thundmobility>().enabled = false;
            /*GameObject.Find("thor").GetComponent<Camera>().enabled = false;
            GameObject.Find("zeus").GetComponent<Camera>().enabled = false;
            GameObject.Find("indra").GetComponent<Camera>().enabled = true;
            GameObject.Find("thund").GetComponent<Camera>().enabled = false;*/
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (GameObject.Find("zeus")) GameObject.Find("zeus").GetComponent<Zeusmobility>().enabled = false;
            if (GameObject.Find("thor")) GameObject.Find("thor").GetComponent<Playermobility>().enabled = false;
            if (GameObject.Find("indra")) GameObject.Find("indra").GetComponent<Indramobility>().enabled = false;
            if (GameObject.Find("thund")) GameObject.Find("thund").GetComponent<Thundmobility>().enabled = true;
            /*GameObject.Find("thor").GetComponent<Camera>().enabled = false;
            GameObject.Find("zeus").GetComponent<Camera>().enabled = false;
            GameObject.Find("indra").GetComponent<Camera>().enabled = false;
            GameObject.Find("thund").GetComponent<Camera>().enabled = true;*/
        }

    }
}
