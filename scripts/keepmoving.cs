using UnityEngine;
using System.Collections;

public class keepmoving : MonoBehaviour {
public float speed = 0.0000001f;
    // Use this for initialization
    void Start ()
    {
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector2.up * speed);
    }
}
