using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Animator anim;



    public float speed = 20;

    //Inventory Items =========================================
    //Puzzle 1
    bool battery = false;
    bool violinCables = false;
    public bool violinRune = false;

    //Puzzle 2
    bool xylophoneKey1 = false;
    bool xylophoneKey2 = false;
    public bool xylophoneRune = false;

    //Puzzle 3
    bool key1 = false;
    bool key2 = false;
    bool key3 = false;
    public bool drumRune = false;

    //Puzzle 4
    bool pianoKey1 = false;
    bool pianoKey2 = false;
    bool pianoKey3 = false;
    public bool pianoRune = false;

    //Puzzle 5
    bool finger = false;
    bool flutePiece2 = false;
    bool fluteBreath = false;
    public bool fluteRune = false;

    //Meta-Puzzle
    bool doorKey = false;


    float h = 0;
    float v = 0;
    SpriteRenderer spr;


    bool useOnce = true;

    public MusicController musicPlayer;

    public AudioSource pickup;
    public AudioSource collect;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position += new Vector3(h, 0, v);

        if (h < 0)
        {
            spr.flipX = true;
            anim.SetBool("isMoving", true);
        }
        else if (h > 0)
        {
            spr.flipX = false;
            anim.SetBool("isMoving", true);
        }
        else { anim.SetBool("isMoving", false); }

        if (v != 0)
        {

            anim.SetBool("isMoving", true);

        }
        else if (v + h == 0) { anim.SetBool("isMoving", false); }


        if (violinRune == true)
        {
            musicPlayer.violinPlaying = true;

        }
        if (pianoRune == true)
        {
            musicPlayer.pianoPlaying = true;

        }
        if (drumRune == true)
        {
            musicPlayer.drumsPlaying = true;

        }
        if (xylophoneRune == true)
        {
            musicPlayer.xyloPlaying = true;

        }
        if (fluteRune == true)
        {
            musicPlayer.flutePlaying = true;

        }






    }


    public bool checkBattery()
    {
        return battery;
    }

    public bool checkCables()
    {
        return violinCables;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Moveable")
        {
            if (Input.GetKey(KeyCode.E))
            {
                other.transform.parent = transform;
              
                
                if (useOnce == true)
                {

                    pickup.Play();
                    useOnce = false;

                }


            }

            else
            {
                useOnce = true;
                other.transform.parent = null;
            }
        }


        if(other.tag == "Battery")
        {
            if (Input.GetKey(KeyCode.E))
            {
                battery = true;
                other.gameObject.SetActive(false);
                

                    collect.Play();
                    useOnce = false;

                
                
            }
        }

        if (other.tag == "Cables")
        {
            if (Input.GetKey(KeyCode.E))
            {
                violinCables = true;
                other.gameObject.SetActive(false);
                
                    collect.Play();
                   
               
            }
        }
    }

}
