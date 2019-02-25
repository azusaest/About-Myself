using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Training : MonoBehaviour {
    Component halo;
    public static bool isTraining;
    public static bool arriveTrainingPlace;
    public GameObject player;
    private Vector3 currentPosition = new Vector3();
    bool isClick = false;
   // public Slider loadingBar;
   // bool hasBar;

    enum CharacterState
    {
        Idle,
        Walk,
        Run
    }
    // Use this for initialization
    void Start () {
        halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
        isTraining = false;
        arriveTrainingPlace = false;
       // hasBar = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(isTraining == true)
        {
            /*if(hasBar == false)
            {
                GameObject.Find("Canvas").transform.Find("Slider").gameObject.SetActive(true);
                hasBar = true;
            }*/
            StartCoroutine(StartTraining());
        }
       // GameObject.Find("Canvas").transform.Find("Slider").gameObject.SetActive(false);
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
        isClick = true;
    }

    //當玩家抵達訓練場時，則記錄玩家位置，以便玩家訓練完時回到該位置
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("TC");
        if(isClick == true)
        {
            arriveTrainingPlace = true;
            currentPosition = player.transform.position;
            isTraining = true;
            isClick = false;
        }
    }

    //玩家進行訓練，時間為5秒
    IEnumerator StartTraining()
    {
        player.transform.position = gameObject.transform.position;
        Character.state = (int)CharacterState.Run;
        for(int i = 1; i <= 5; i++)
        {
            yield return new WaitForSeconds(1);
            //loadingBar.value = (float)0.2*i;
        }
        isTraining = false;
        Character.state = (int)CharacterState.Idle;
        player.transform.position = currentPosition;
        arriveTrainingPlace = false;
        GameControl.trainingCount = 1;
        yield return new WaitForSeconds(1);
        //GameObject.Find("Canvas").transform.Find("Slider").gameObject.SetActive(false);
        //hasBar = false;
    }
}
