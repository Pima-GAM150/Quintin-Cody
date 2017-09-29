using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float speed = 1f;
    public float rotationspeed = 1f;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Rotate(0f,Input.GetAxis("Horizontal")*Time.deltaTime* rotationspeed,0f);
        transform.Translate(0f,0f,Input.GetAxis("Vertical") * Time.deltaTime* speed);
    }
}
