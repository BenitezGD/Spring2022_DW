using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViolinPanel : MonoBehaviour
{
    CanvasGroup canvasGroup;

    public Scrollbar scroll1;
    public Scrollbar scroll2;

    public Image scroll1Correct;
    public Image scroll2Correct;

    //Check if the player has the Violin Cables to be able to use the panel
    public bool violinCable = false;
    public Image violinCables;

    public bool scroll1Position = false;
    public bool scroll2Position = false;

    public PlayerController player;

    public bool puzzleSolved = false;

    // Start is called before the first frame update
    void Start()
    {
        scroll1.interactable = false;
        scroll2.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(scroll1Position && scroll2Position)
        {
            puzzleSolved = true;
        }

        else
        {
            puzzleSolved = false;
        }


        if (violinCable == true)
        {
            scroll1.interactable = true;
            scroll2.interactable = true;
            violinCables.gameObject.SetActive(true);
        }
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

    public void violinCablesGotten()
    {
        if(player.checkCables())
        {
            violinCable = true;
        }
    }
}
