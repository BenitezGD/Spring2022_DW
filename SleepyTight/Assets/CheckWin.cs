using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWin : MonoBehaviour
{
    public ViolinPanel vp;
    public ViolinTune vt;

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
            violinRune.gameObject.SetActive(true);
        }
    }
}
