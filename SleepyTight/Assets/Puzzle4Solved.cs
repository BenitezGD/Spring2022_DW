using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle4Solved : MonoBehaviour
{
    public FlutePanel flutePanel;
    public PlayerController player;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flutePanel.puzzleSolved)
        {
            door.SetActive(false);
            player.fluteRune = true;
        }
    }
}
