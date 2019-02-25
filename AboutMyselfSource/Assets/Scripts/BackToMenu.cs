using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
    ArcaletGame ag;
    // Use this for initialization
    void Start () {
        ag = AGCC.ag;
    }

    public void Click()
    {
        //若有使用者連線，則斷開連線
        if (ag != null)
        {
            ag.Dispose();
        }
        Debug.Log("Back to the title menu");
        SceneManager.LoadScene(0);
    }
}
