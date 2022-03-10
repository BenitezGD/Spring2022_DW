using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinPanel : MonoBehaviour
{
    CanvasGroup canvasGroup;

    public Scrollbar scroll1;
    public Image knob1Correct;

    //Check if the player has the Violin Cables to be able to use the panel
    public bool violinCable = false;
    public bool scroll1Position = false;

    private float startPosX;

        

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scroll1.value > 0.75 && scroll1.value < 0.90)
        {
            knob1Correct.gameObject.SetActive(true);
        }

        else
        {
            knob1Correct.gameObject.SetActive(false);
        }
    }
}
