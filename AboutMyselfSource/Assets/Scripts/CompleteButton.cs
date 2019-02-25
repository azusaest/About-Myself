using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteButton : MonoBehaviour {

    public void Click()
    {
        GameControl.missionComplete = true;
    }
}
