using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPuzzleSolved : MonoBehaviour
{
    public PlayerController player;
    public GameObject door;
    public RuneArrange runeArrange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(runeArrange.puzzleSolved)
        {
            door.SetActive(false);
            player.pianoRune = false;
            player.xylophoneRune = false;
            player.violinRune = false;
            player.fluteRune = false;
        }
    }
}
