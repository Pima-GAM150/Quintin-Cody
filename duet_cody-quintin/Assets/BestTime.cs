using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BestTime : MonoBehaviour {
    private float score = 0.0f;
    public Text BestText;
    // Use this for initialization
    void Start () {
        BestText.text = "Best : " + ((int)PlayerPrefs.GetFloat("Best")).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if(PlayerPrefs.GetFloat("Best") < score)
        PlayerPrefs.SetFloat("Best", score);
        

    }
}
