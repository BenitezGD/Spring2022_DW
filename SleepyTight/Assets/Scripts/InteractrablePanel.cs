using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractrablePanel : MonoBehaviour
{
    private bool playerOverlapping = false;

    public GameObject Player;

    public GameObject UI_Panel;

    public bool playerInteracting = false;


    void Update()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
            if (playerOverlapping)
            {
                playerInteracting = true;
                UI_Panel.SetActive(true);
            }
        }
    }

    void OnTriggerStay2D (Collider other)
    {
        if (other.tag == "Player")
        {
            playerOverlapping = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOverlapping = false;
        }
    }
}
