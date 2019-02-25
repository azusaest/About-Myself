using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {
    ArcaletGame ag;
    // Use this for initialization
    void Start () {
        ag = AGCC.ag;
    }

    public void Click()
    {
        //如果有使用者連線則斷開連線
        if (ag != null)
        {
            ag.Dispose();
        }
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
