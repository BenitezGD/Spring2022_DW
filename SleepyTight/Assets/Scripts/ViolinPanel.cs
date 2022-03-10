using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinPanel : MonoBehaviour
{
    CanvasGroup canvasGroup;

    public Scrollbar scroll1;
    public Scrollbar scroll2;

    public RectTransform knob1;

    public Image scroll1Correct;
    public Image scroll2Correct;

    //Check if the player has the Violin Cables to be able to use the panel
    public bool violinCable = false;

    public bool scroll1Position = false;
    public bool scroll2Position = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        //Top Scroll Bar
        if (scroll1.value > 0.75 && scroll1.value < 0.90)
        {
            scroll1Correct.gameObject.SetActive(true);
            scroll1Position = true;

        }

        else
        {
            scroll1Correct.gameObject.SetActive(false);
            scroll1Position = false;
        }

        //Bottom Scroll Bar
        if (scroll2.value > 0.19 && scroll2.value < 0.33)
        {
            scroll2Correct.gameObject.SetActive(true);
            scroll2Position = true;

        }

        else
        {
            scroll2Correct.gameObject.SetActive(false);
            scroll2Position = false;
        }

    }
}
