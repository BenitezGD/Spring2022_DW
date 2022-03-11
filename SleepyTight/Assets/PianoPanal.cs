using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoPanal : MonoBehaviour
{
    public Button pianoKey2;
    public Button pianoKey4;
    public Button pianoKey5;

    public Button pianoKey2Empty;
    public Button pianoKey4Empty;
    public Button pianoKey5Empty;

    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PianoKey2Collected()
    {
        if(player.checkPianoKey2())
        {
            pianoKey2.gameObject.SetActive(true);
            pianoKey2Empty.gameObject.SetActive(false);
        }
    }

    public void PianoKey4Collected()
    {
        if (player.checkPianoKey4())
        {
            pianoKey4.gameObject.SetActive(true);
            pianoKey4Empty.gameObject.SetActive(false);
        }
    }

    public void PianoKey5Collected()
    {
        if (player.checkPianoKey5())
        {
            pianoKey5.gameObject.SetActive(true);
            pianoKey5Empty.gameObject.SetActive(false);
        }
    }

}
