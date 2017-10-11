using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCompleteTrigger : MonoBehaviour {

    public GameObject LapCompleteTrig;

    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
    }
}
