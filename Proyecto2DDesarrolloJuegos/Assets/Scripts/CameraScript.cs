using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 TargetPos;
    public float HaciaAdelante;

    private void Start()
    {
    }

    void Update()
    {
        TargetPos = transform.position;
        TargetPos.x = player.transform.position.x;
        //TargetPos.y = player.transform.position.y;
        

        //if (player.GetComponent<SpriteRenderer>().flipX == true)
        //{
        //    transform.position = new Vector3(TargetPos.x - HaciaAdelante, TargetPos.y, TargetPos.z);
        //}
        //if (player.transform.localScale.x == -8)
        //{
            
        //}


        transform.position = TargetPos;


    }
}
