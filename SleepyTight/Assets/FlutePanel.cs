using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlutePanel : MonoBehaviour
{
    public Image fluteMouth;
    public Image fluteEnd;

    public Button fluteMouthEmpty;
    public Button fluteEndEmpty;

    public bool puzzleSolved;

    public PlayerController player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fluteMouth.IsActive() && fluteEnd.IsActive())
        {
            puzzleSolved = true;
        }
    }

    public void fluteEndCollected()
    {
        if(player.checkFluteEnd())
        {
            fluteEnd.gameObject.SetActive(true);
            fluteEndEmpty.gameObject.SetActive(false);
        }
    }

    public void fluteMouthCollected()
    {
        if (player.checkFluteMouth())
        {
            fluteMouth.gameObject.SetActive(true);
            fluteMouthEmpty.gameObject.SetActive(false);
        }
    }
}
