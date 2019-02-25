using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//管理遊戲進度
public class GameControl : MonoBehaviour {
    public int mission;
    public Text missionText;
    public static bool missionComplete;
    public static int certificateCount;
    public static int trainingCount;
    public static int passRoadCount;

    //資料介面的4個按鈕
    public Button dataButton;
    public Button abilityButton;
    public Button projectButton;
    public Button otherButton;

    // Use this for initialization
    void Start()
    {
        mission = 1;
        certificateCount = 0;
        trainingCount = 0;
        passRoadCount = 0;
        missionComplete = false;
        dataButton.interactable = false;
        abilityButton.interactable = false;
        projectButton.interactable = false;
        otherButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (mission)
        {
            case 1:
                missionText.text = "任務一 : 取得證書 (" + certificateCount + " / 4)";
                if (certificateCount == 4)
                {
                    setCompleteButton(true);
                    if (missionComplete == true)
                    {
                        mission = 2;            //移動到下一個任務
                        trainingCount = 0;      //初始化下一個任務所需的參數
                        missionComplete = false;//重新設定任務完成為否
                        setCompleteButton(false);
                        dataButton.interactable = true;
                    }
                }
                break;

            case 2:
                missionText.text = "任務二 : 完成訓練 (" + trainingCount + " / 1)";
                if (trainingCount == 1)
                {
                    setCompleteButton(true);
                    if (missionComplete == true)
                    {
                        mission = 3;
                        passRoadCount = 0;
                        missionComplete = false;
                        setCompleteButton(false);
                        abilityButton.interactable = true;
                    }
                }
                break;

            case 3:
                missionText.text = "任務三 : 經過森林小路 (" + passRoadCount + " / 1)";
                if (passRoadCount == 1)
                {
                    setCompleteButton(true);
                    if (missionComplete == true)
                    {
                        mission = 4;
                        missionComplete = false;
                        setCompleteButton(false);
                        projectButton.interactable = true;
                        otherButton.interactable = true;
                    }
                }
                break;

            case 4:
                missionText.text = "任務完成 !";
                break;
        }
    }

    //實作任務完成按鈕的出現或消失
    void setCompleteButton(bool tf)
    {
        GameObject.Find("Canvas").transform.Find("Complete").gameObject.SetActive(tf);
    }
}
