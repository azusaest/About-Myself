using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassEnd : MonoBehaviour {
    //通過樹林小路的尾端
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("pass end");
        if (PassStart.start == true)
        {
            GameControl.passRoadCount = 1;
            PassStart.start = false;
        }
    }
}
