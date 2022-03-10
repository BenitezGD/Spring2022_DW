using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;

    //Inventory Items =========================================
    //Puzzle 1
    bool battery = false;
    bool violinCables = false;
    bool violinRune = false;

    //Puzzle 2
    bool xylophoneKey1 = false;
    bool xylophoneKey2 = false;
    bool xylophoneRune = false;

    //Puzzle 3
    bool key1 = false;
    bool key2 = false;
    bool key3 = false;
    bool drumRune = false;

    //Puzzle 4
    bool pianoKey1 = false;
    bool pianoKey2 = false;
    bool pianoKey3 = false;
    bool pianoRune = false;

    //Puzzle 5
    bool finger = false;
    bool flutePiece2 = false;
    bool fluteBreath = false;
    bool fluteRune = false;

    //Meta-Puzzle
    bool doorKey = false;


    float h = 0;
    float v = 0;
    SpriteRenderer spr;

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

        if(h < 0 )
        {
            spr.flipX = true;
        }

        else if (h > 0)
        {
            spr.flipX = false;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Moveable")
        {
            if(Input.GetKey(KeyCode.E))
            {
                other.transform.parent = transform;
                
            }

            else
            {
                other.transform.parent = null;
            }
        }

        if(other.tag == "Item")
        {
            
        }
    }

}
