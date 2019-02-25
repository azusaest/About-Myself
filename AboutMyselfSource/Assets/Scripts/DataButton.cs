using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//實作玩家按下"資料"按鈕時的動作
public class DataButton : MonoBehaviour {
    bool dataOpen;

	// Use this for initialization
	void Start () {
        dataOpen = false;
	}

    public void Click()
    {
        Debug.Log("click data button");
        //當資料介面尚未打開時，則打開資料的介面，反之則關閉介面
        if(dataOpen == false)
        {
            dataOpen = true;
            GameObject.Find("Canvas").transform.Find("PlayerData").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("Canvas").transform.Find("PlayerData").gameObject.SetActive(false);
            dataOpen = false;
        }
    }
}
