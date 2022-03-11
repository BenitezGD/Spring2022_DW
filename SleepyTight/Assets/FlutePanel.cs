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

    public AudioSource badNote;
    public AudioSource n1;
    public AudioSource n2;
    public AudioSource n3;
    public AudioSource n4;

    public GameObject fluteRune;


    // Start is called before the first frame update
    void Start()
    {
        badNote.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(fluteMouth.IsActive() && fluteEnd.IsActive())
        {
            puzzleSolved = true;

            fluteRune.gameObject.SetActive(true);

            if (!n1.isPlaying && !n4.isPlaying) {

                n1.Play();
                n4.Play();

            }



        }
    }

    public void fluteEndCollected()
    {
        if(player.checkFluteEnd())
        {
            fluteEnd.gameObject.SetActive(true);
            fluteEndEmpty.gameObject.SetActive(false);
            n2.Play();
        }
    }

    public void fluteMouthCollected()
    {
        if (player.checkFluteMouth())
        {
            fluteMouth.gameObject.SetActive(true);
            fluteMouthEmpty.gameObject.SetActive(false);
            n3.Play();
        }
    }
}
