﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AGCC : MonoBehaviour {
    //以下gguid、sguid、certificate為arcalet雲端遊戲平台資料庫的連接所需的id以及憑證
    private const string gguid = "c3ba317c-9ec0-4744-bf68-f866d6ae370d";
    private const string sguid = "acc401ae-23f9-3740-94e9-ace232ef69c0";
    byte[] certificate = { 0x74, 0x98, 0x99, 0x6b, 0x09, 0xec, 0xa8, 0x41, 0xa9, 0x61, 0xbf, 0x80, 0xb3, 0xe4, 0x43, 0xac, 0xd5, 0xaf, 0x35, 0x94, 0xdf, 0xe7, 0xf4, 0x48, 0xbe, 0xfc, 0xfb, 0xc6, 0x89, 0x43, 0x6a, 0xac, 0x4f, 0xea, 0x39, 0x79, 0xc8, 0x4c, 0xe6, 0x45, 0x9e, 0xa4, 0xe2, 0x7b, 0xe4, 0x67, 0xc0, 0xcd, 0xeb, 0x1a, 0x91, 0xda, 0xd4, 0x2f, 0x50, 0x44, 0xa9, 0xbd, 0xa3, 0x8c, 0xe4, 0x09, 0x57, 0x6c, 0x18, 0x2d, 0x88, 0x82, 0xb3, 0x88, 0x1e, 0x45, 0x88, 0xf3, 0x8c, 0xcc, 0xb0, 0xa7, 0x57, 0xe4, 0x54, 0x30, 0xb8, 0x96, 0x5b, 0xa7, 0xb1, 0x44, 0xbc, 0x38, 0xc8, 0xe4, 0x5b, 0xb9, 0x61, 0xc5, 0xb8, 0x5d, 0x70, 0x84, 0x4a, 0xd1, 0x48, 0x4c, 0xa0, 0xa7, 0xc5, 0x28, 0x2b, 0x79, 0xcb, 0x55, 0xa9, 0xfb, 0xd9, 0x20, 0x1d, 0x03, 0x2d, 0x4d, 0x8b, 0xf4, 0x6c, 0xde, 0xc7, 0xe8, 0xf7, 0x3c };

    public static ArcaletGame ag = null;//宣告並初始化使用者連線的物件

    //建立使用者連線
    public void ArcaletLaunch(string username, string password)
    {
        ag = new ArcaletGame(username, password, gguid, sguid, certificate);
        ag.onCompletion += OnCompletion;
        ag.Launch();
    }

    //連線至arcalet
    void OnCompletion(int code, ArcaletGame game)
    {
        //若code為0，則連線成功，反之則為失敗
        if (code == 0)
        {
            Debug.Log("登入成功");
            SceneManager.LoadScene(2);
        }
        else
        {
            Debug.LogWarning("登入失敗，錯誤代碼：" + code);
        }
    }
}
