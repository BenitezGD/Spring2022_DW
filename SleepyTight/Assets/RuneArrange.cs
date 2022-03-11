using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneArrange : MonoBehaviour
{
    public Drag flute;
    public Drag xylo;
    public Drag piano;
    public Drag violin;

    public bool puzzleSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flute.correct && xylo.correct && piano.correct && violin.correct)
        {
            puzzleSolved = true;
        }

    }
}
