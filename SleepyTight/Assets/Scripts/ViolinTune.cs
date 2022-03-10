using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ViolinTune : MonoBehaviour
{
    int[] answer = { 3, 1, 2 };
    public int[] playerChoice = new int[3];

    public Image[] sequence = new Image[4];

    public Button green; //1
    public Button cyan; //2
    public Button yellow; //3

    public Image battery;
    public bool batteryPlaced = false;

    public Image solved;

    int buttonsPressedInARow = 0;
    float timer = 1.0f;
    int sequenceNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        green.interactable = false;
        cyan.interactable = false;
        yellow.interactable = false;

        battery.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(batteryPlaced == true)
        {
            green.interactable = true;
            cyan.interactable = true;
            yellow.interactable = true;

            battery.gameObject.SetActive(true);



            timer -= Time.deltaTime;

            if(timer < 0)
            {
                if(sequenceNumber == 0)
                {
                    sequence[sequenceNumber].gameObject.SetActive(false);
                    sequence[sequenceNumber+1].gameObject.SetActive(true);
                    sequenceNumber++;
                    timer = 1.0f;
                }

                else if (sequenceNumber == 1)
                {
                    sequence[sequenceNumber].gameObject.SetActive(false);
                    sequence[sequenceNumber + 1].gameObject.SetActive(true);
                    sequenceNumber++;
                    timer = 1.0f;
                }

                else if (sequenceNumber == 2)
                {
                    sequence[sequenceNumber].gameObject.SetActive(false);
                    sequence[sequenceNumber + 1].gameObject.SetActive(true);
                    sequenceNumber++;
                    timer = 1.0f;
                }

                else
                {
                    sequence[sequenceNumber].gameObject.SetActive(false);
                    sequenceNumber = 0;
                    sequence[sequenceNumber].gameObject.SetActive(true);
                    timer = 4.0f;
                }
            }


        }

        if(buttonsPressedInARow == 3)
        {
            if(playerChoice[0] == answer[0] && playerChoice[1] == answer[1] && playerChoice[2] == answer[2])
            {
                solved.gameObject.SetActive(true);
                green.interactable = false;
                cyan.interactable = false;
                yellow.interactable = false;
            }

            else
            {
                for(int i = 0; i < playerChoice.Length; i++)
                {
                    green.interactable = true;
                    cyan.interactable = true;
                    yellow.interactable = true;
                    playerChoice[i] = 0;    
                }
                buttonsPressedInARow = 0;
                //PLAY SOUND HERE WHEN WRONG
            }
        }
    }

    public void greenPressed()
    {
        for(int i = 0; i < playerChoice.Length; i++)
        {
            if(playerChoice[i] == 0)
            {
                playerChoice[i] = 1;
                green.interactable = false;
                buttonsPressedInARow++;
                break;
            }
        }
    }

    public void cyanPressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 2;
                cyan.interactable = false;
                buttonsPressedInARow++;
                break;
            }
        }
    }

    public void yellowPressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 3;
                yellow.interactable = false;
                buttonsPressedInARow++;
                break;
            }
        }
    }

    public void checkForBattery()
    {
        //CHECK FOR BATTERY IN PLAYER INVENTORY HERE
        //IF there is, place battery 
        //IF NOT, do nothing

        batteryPlaced = true;
    }
}
