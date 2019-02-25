using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        //計算攝影機與使用者之間的向量
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //使攝影機跟著玩家移動
        transform.position = player.transform.position + offset;
    }
}
