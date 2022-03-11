using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource pianoA;
    public AudioSource pianoB;
    public AudioSource drums;
    public AudioSource violinA;
    public AudioSource violinB;
    public AudioSource xyloA;
    public AudioSource xyloB;
    public AudioSource fluteA;
    public AudioSource fluteB;

    public bool pianoPlaying;
    public bool drumsPlaying;
    public bool violinPlaying;
    public bool xyloPlaying;
    public bool flutePlaying;

    public int count = 1;
    public float timer = 0;
    public float triggerTime = 4.8f;

    private bool first = true;


    

    // Update is called once per frame
    void Update()
    {
        drumsPlaying = true;
        if (first == true)
        {
            if (pianoPlaying == true)
            {
                pianoA.Play();
            }
            if (drumsPlaying == true)
            {
                drums.Play();
            }
            if (violinPlaying == true)
            {
                violinA.Play();
            }
            if (xyloPlaying == true)
            {
                xyloA.Play();
            }
            if (flutePlaying == true)
            {
                fluteA.Play();
            }

            first = false;

        }



        timer += Time.deltaTime;
        if (timer >= triggerTime) {

            timer = 0;
            if (count == 1)
            {
                count = 2;

            }
            else if (count == 2)
            {

                count = 1;

            }


            if (pianoPlaying == true) {
                if (count == 1){
                    pianoA.Play();
                }
                else if (count == 2) {
                    pianoB.Play();
                }
            }

            if (drumsPlaying == true)
            {
                drums.Play();
            }

            if (violinPlaying == true)
            {
                if (count == 1)
                {
                    violinA.Play();
                }
                else if (count == 2)
                {
                    violinB.Play();
                }
            }

            if (xyloPlaying == true)
            {
                if (count == 1)
                {
                    xyloA.Play();
                }
                else if (count == 2)
                {
                    xyloB.Play();
                }
            }

            if (flutePlaying == true)
            {
                if (count == 1)
                {
                    fluteA.Play();
                }
                else if (count == 2)
                {
                    fluteB.Play();
                }
            }


           



        }




    }
}
