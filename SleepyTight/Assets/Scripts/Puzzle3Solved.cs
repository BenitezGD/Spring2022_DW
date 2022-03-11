using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Solved : MonoBehaviour
{
    public PianoPanal pianoPanel;
    public PlayerController player;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pianoPanel.puzzleSolved)
        {
            door.SetActive(false);
            player.pianoRune = true;
        }
    }
}
