using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWin : MonoBehaviour
{
   

    public ViolinPanel vp;
    public ViolinTune vt;

    public GameObject door;
    public PlayerController player;
    public Image violinRune;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if(vp.puzzleSolved && vt.puzzleSolved)
            {
                door.gameObject.SetActive(false);
                violinRune.gameObject.SetActive(true);
                player.violinRune = true;
            }
        
    }

}
