using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public teleportRooms cam;


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
    bool pianoKey2 = false;
    bool pianoKey4 = false;
    bool pianoKey5 = false;
    public bool pianoRune = false;

    //Puzzle 5
    bool finger = false;
    bool fluteEnd = false;
    bool fluteMouth = false;
    public bool fluteRune = false;

    //Meta-Puzzle
    bool doorKey = false;


    float h = 0;
    float v = 0;
    SpriteRenderer spr;


    bool useOnce = true;

    public MusicController musicPlayer;

    public GameObject questionMark;
    public bool interact;

    public AudioSource pickup;
    public AudioSource collect;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        questionMark.gameObject.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {

        if (interact == true)
        {
            questionMark.gameObject.SetActive(true);
        }
        else if (interact == false)
        {
            questionMark.gameObject.SetActive(false);
        }


        

        
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

    public bool checkBigKey()
    {
        return xylophoneKey1;
    }

    public bool checkSmallKey()
    {
        return xylophoneKey2;
    }

    public bool checkPianoKey2()
    {
        return pianoKey2;
    }

    public bool checkPianoKey4()
    {
        return pianoKey4;
    }

    public bool checkPianoKey5()
    {
        return pianoKey5;
    }

    public bool checkFluteEnd()
    {
        return fluteEnd;
    }

    public bool checkFluteMouth()
    {
        return fluteMouth;
    }

    private void OnTriggerStay(Collider other)
    {
        //moving objects
        if (other.tag == "Moveable")
        {
            interact = true;
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

        //Collect Battery
        if (other.tag == "Battery")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                battery = true;
                other.gameObject.SetActive(false);
                interact = false;
                collect.Play();
                useOnce = false;



            }
        }

        if (other.tag == "Interact")
        {

            interact = true;


        }



        //Collect Cables
        if (other.tag == "Cables")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                violinCables = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();


            }
        }

        //Collect BigKey
        if (other.tag == "BigKey")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                xylophoneKey1 = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }
        }

        //Collect SmallKey
        if (other.tag == "SmallKey")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                xylophoneKey2 = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }
        }

        //Collect PianoKey2
        if (other.tag == "PianoKey2")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                pianoKey2 = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }
        }

        //Collect PianoKey4
        if (other.tag == "PianoKey4")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                pianoKey4 = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }

        }

        //Collect PianoKey5
        if (other.tag == "PianoKey5")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                pianoKey5 = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }

        }

        //Collect FluteMouth
        if (other.tag == "FluteMouth")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                fluteMouth = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }

        }
        //Collect FluteEnd
        if (other.tag == "FluteEnd")
        {
            interact = true;
            if (Input.GetKey(KeyCode.E))
            {
                fluteEnd = true;
                other.gameObject.SetActive(false);
                interact = false;

                collect.Play();
            }

        }
    }


    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Cables")
        {
            interact = false;
        }
        if (col.tag == "Interact")
        {
            interact = false;
        }
        if (col.tag == "Battery")
        {
            interact = false;
        }
        if (col.tag == "Moveable")
        {
            interact = false;
        }

        if(col.tag == "BigKey")
        {
            interact = false;
        }

        if (col.tag == "SmallKey")
        {
            interact = false;
        }

        if(col.tag == "PianoKey2")
        {
            interact = false;
        }

        if (col.tag == "PianoKey4")
        {
            interact = false;
        }

        if (col.tag == "PianoKey5")
        {
            interact = false;
        }

        if (col.tag == "FluteMouth")
        {
            interact = false;
        }

        if (col.tag == "FluteEnd")
        {
            interact = false;
        }

    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "1e")
        {
            cam.prepLoad(1);
        }
        else if (col.tag == "2e")
        {
            cam.prepLoad(2);
        }
        else if (col.tag == "3e")
        {
            cam.prepLoad(3);
        }
        else if (col.tag == "4e")
        {
            cam.prepLoad(4);
        }
        else if (col.tag == "5e")
        {
            cam.prepLoad(5);
        }
        else if (col.tag == "6e")
        {
            cam.prepLoad(6);
        }
        
    }

}
