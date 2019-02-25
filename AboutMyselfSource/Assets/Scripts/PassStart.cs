using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassStart : MonoBehaviour {
    public static bool start;
	// Use this for initialization
	void Start () {
        start = false;
	}
    //通過樹林小路的起點
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pass start");
        start = true;
    }
}
