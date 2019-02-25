using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CertificateControl : MonoBehaviour {
    Component halo;
    public static bool itemCanDestroy;
    bool itemChosen;

    //初始化物件
    // Use this for initialization
    void Start () {
        halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
        itemCanDestroy = false;
        itemChosen = false;
    }
	
	// Update is called once per frame
	void Update () {
        //當滑鼠點選"證書"物件且玩家抵達該物件的位置時
        if (itemChosen == true && itemCanDestroy == true)
        {
            Debug.Log("Get the Certificate");
            GameControl.certificateCount++;
            Destroy(this.gameObject);
            itemCanDestroy = false;
        }
    }

    private void OnMouseEnter()
    {
        halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
    }

    private void OnMouseExit()
    {
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
    }

    private void OnMouseDown()
    {
        itemChosen = true;
        Debug.Log("click the certificate");
    }
}
