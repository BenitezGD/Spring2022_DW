using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportRooms : MonoBehaviour
{
    public Animator anim;

    public GameObject player;
    public Transform playerPos;

    public int tpn;

    public Transform tp1;
    public Transform tp2;
    public Transform tp3;
    public Transform tp4;
    public Transform tp5;
    
    public Transform ctp1;
    public Transform ctp2;
    public Transform ctp3;
    public Transform ctp4;
    public Transform ctp5;
   

    public GameObject finalCanvas;

    public void teleportRoom()
    {
        if(tpn == 1)
        {

            transform.position = ctp1.position;
            playerPos.position = tp1.position;

        }else if (tpn == 2)
        {
            transform.position = ctp2.position;
            playerPos.position = tp2.position;
        }
        else if (tpn == 3)
        {
            transform.position = ctp3.position;
            playerPos.position = tp3.position;
        }
        else if (tpn == 4)
        {
            transform.position = ctp4.position;
            playerPos.position = tp4.position;
        }
        else if (tpn == 5)
        {
            transform.position = ctp5.position;
            playerPos.position = tp5.position;
        }
        else if(tpn == 6)
        {
            finalCanvas.gameObject.SetActive(true);
        }



    }

    public void prepLoad(int roomNum)
    {

        anim.SetTrigger("transition");
        tpn = roomNum;

    }



}
