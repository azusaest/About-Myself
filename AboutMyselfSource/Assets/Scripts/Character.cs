using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//設定玩家的動作動畫
public class Character : MonoBehaviour {
    public Animator anim;
    public static int state;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger("state", state);
    }
}
