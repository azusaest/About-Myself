using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//實作滑鼠點擊使玩家移動
public class MouseClickMove : MonoBehaviour {
    public GameObject player;
    private Vector3 target = new Vector3();
    public float speed = 10;
    bool isClickItems = false;
    bool isClickTraing = false;

    enum CharacterState
    {
        Idle,
        Walk,
        Run
    }

    // Use this for initialization
    void Start () {
        //使玩家面向正前方
        target = new Vector3(38,0,-100);
    }
	
	// Update is called once per frame
	void Update () {
        //利用投影的方式使滑鼠座標轉換成3D座標
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        float step = speed * Time.deltaTime;
        Vector3 targetDir = target - player.transform.position;
        Vector3 newDir = Vector3.RotateTowards(player.transform.forward, targetDir, step * 10, 0.0F);

        if (Physics.Raycast(ray, out hit))
        {
            //若玩家點擊地板
            if (Input.GetMouseButtonDown(1) && hit.transform.gameObject.tag == "Floor")
            {
                Debug.Log("Floor");
                Character.state = (int)CharacterState.Walk;
                target = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }
            //若玩家點擊"證書"物件
            if (Input.GetMouseButtonDown(0) && hit.transform.gameObject.tag == "Certificate")
            {
                isClickItems = true;
                target = new Vector3(hit.point.x, player.transform.position.y, hit.point.z);

                if (Vector3.Distance(player.transform.position, target) < 1f)
                {
                    Debug.Log("Certificate true");
                    CertificateControl.itemCanDestroy = true;
                    isClickItems = false;
                }
                else
                {
                    Debug.Log("Certificate false");
                    Character.state = (int)CharacterState.Walk;
                }
            }
            //若玩家點擊"訓練場"物件
            if (Input.GetMouseButtonDown(0) && hit.transform.gameObject.tag == "TrainingPlace")
            {
                Debug.Log("TrainingPlace");
                Character.state = (int)CharacterState.Walk;
                target = new Vector3(hit.point.x, player.transform.position.y, hit.point.z);
                isClickTraing = true;
            }
        }

        player.transform.rotation = Quaternion.LookRotation(newDir);

        if (Character.state == (int)CharacterState.Walk)
        {
            if (isClickTraing == true && Training.arriveTrainingPlace == true)
            {
                isClickTraing = false;
            }
            //當玩家到達"證書"物件目標的位置時，則可消滅證書物件
            else if (Vector3.Distance(player.transform.position, target) < 1f)
            {
                Character.state = (int)CharacterState.Idle;

                if(isClickItems == true)
                {
                    Debug.Log("isClickItems");
                    CertificateControl.itemCanDestroy = true;
                    isClickItems = false;
                }
            }
            player.transform.position = Vector3.MoveTowards(player.transform.position, target, step);
        }
    }
}
