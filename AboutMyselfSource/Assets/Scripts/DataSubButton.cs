using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//實作資料介面的4個按鈕
public class DataSubButton : MonoBehaviour {
    public Component comp1;         //代表基本資料
    public Component comp2;         //代表程式語言能力
    public Component comp3;         //代表專題
    public Component comp4;         //代表其他
    public Component attentionText;

    // Use this for initialization
    void Start () {
        //attentionText = GameObject.Find("Canvas").transform.Find("PlayerData").transform.Find("Attention");
        attentionText.gameObject.SetActive(true);

        //comp1 = GameObject.Find("Canvas").transform.Find("PlayerData").transform.Find("Data").transform.Find("DataText");
        comp1.gameObject.SetActive(false);

        //comp2 = GameObject.Find("Canvas").transform.Find("PlayerData").transform.Find("Ability").transform.Find("ProgLang");
        comp2.gameObject.SetActive(false);

        //comp3 = GameObject.Find("Canvas").transform.Find("PlayerData").transform.Find("Project").transform.Find("Proj");
        comp3.gameObject.SetActive(false);

        //comp4 = GameObject.Find("Canvas").transform.Find("PlayerData").transform.Find("Other").transform.Find("OtherText");
        comp4.gameObject.SetActive(false);
    }

    public void Click1()
    {
        attentionText.gameObject.SetActive(false);
        comp1.gameObject.SetActive(true);
        comp2.gameObject.SetActive(false);
        comp3.gameObject.SetActive(false);
        comp4.gameObject.SetActive(false);
    }
    public void Click2()
    {
        comp1.gameObject.SetActive(false);
        comp2.gameObject.SetActive(true);
        comp3.gameObject.SetActive(false);
        comp4.gameObject.SetActive(false);
    }

    public void Click3()
    {
        comp1.gameObject.SetActive(false);
        comp2.gameObject.SetActive(false);
        comp3.gameObject.SetActive(true);
        comp4.gameObject.SetActive(false);
    }

    public void Click4()
    {
        comp1.gameObject.SetActive(false);
        comp2.gameObject.SetActive(false);
        comp3.gameObject.SetActive(false);
        comp4.gameObject.SetActive(true);
    }
}
