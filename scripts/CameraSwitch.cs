using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

    public Camera[] Cams;

    // Use this for initialization
    void Start ()
    {
        Cams[0].enabled = true;
        Cams[1].enabled = false;
        Cams[2].enabled = false;
        Cams[3].enabled = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            Cams[0].enabled = true;
            Cams[1].enabled = false;
            Cams[2].enabled = false;
            Cams[3].enabled = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Cams[0].enabled = false;
            Cams[1].enabled = true;
            Cams[2].enabled = false;
            Cams[3].enabled = false;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Cams[0].enabled = false;
            Cams[1].enabled = false;
            Cams[2].enabled = true;
            Cams[3].enabled = false;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Cams[0].enabled = false;
            Cams[1].enabled = false;
            Cams[2].enabled = false;
            Cams[3].enabled = true;
        }
    }
}
