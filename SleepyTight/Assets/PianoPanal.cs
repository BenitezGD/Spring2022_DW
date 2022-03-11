using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoPanal : MonoBehaviour
{
    int[] answer = { 5, 3, 4, 1, 2 };
    public int[] playerChoice = new int[5];
    int keysPressed = 0;

    public MusicController music;
    public Button pianoKey2;
    public Button pianoKey4;
    public Button pianoKey5;

    public Button pianoKey2Empty;
    public Button pianoKey4Empty;
    public Button pianoKey5Empty;

    public PlayerController player;

    public AudioSource note1;
    public AudioSource note2;
    public AudioSource note3;
    public AudioSource note4;
    public AudioSource note5;

    bool musicboxPlaying = false;

    bool pianoNote5 = false;
    bool pianoNote3 = false;
    bool pianoNote4 = false;
    bool pianoNote1 = false;
    bool pianoNote2 = false;
    float timer = 9.0f;

    public bool puzzleSolved = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keysPressed == 5)
        {
            if(answer[0] == playerChoice[0] && answer[1] == playerChoice[1] && answer[2] == playerChoice[2] && answer[3] == playerChoice[3] && answer[4] == playerChoice[4])
            {
                puzzleSolved = true;
            }

            else
            {
                for(int i = 0; i < playerChoice.Length; i++)
                {
                    playerChoice[i] = 0;
                }
            }
        }

        //when music box is pressed
        if(musicboxPlaying)
        {
            timer -= Time.deltaTime;

            if (timer < 9 && !pianoNote5)
            {
                note5.Play();
                pianoNote5 = true;
            }

            if (timer < 7 && !pianoNote3)
            {
                note3.Play();
                pianoNote3 = true;
            }

            if (timer < 5 && !pianoNote4)
            {
                note4.Play();
                pianoNote4 = true;
            }

            if (timer < 3 && !pianoNote1)
            {
                note1.Play();
                pianoNote1 = true;
            }

            if (timer < 1 && !pianoNote2)
            {
                note2.Play();
                pianoNote2 = true;
            }

            if(timer < 0)
            {
                pianoNote5 = false;
                pianoNote3 = false;
                pianoNote4 = false;
                pianoNote1 = false;
                pianoNote2 = false;

                timer = 10f;
                musicboxPlaying = false;

                music.violinA.volume = 1f;
                music.violinB.volume = 1f;
                music.drums.volume = 1f;
                music.xyloA.volume = 1f;
                music.xyloB.volume = 1f;
            }

        }

    }

    public void PianoKey2Collected()
    {
        if(player.checkPianoKey2())
        {
            pianoKey2.gameObject.SetActive(true);
            pianoKey2Empty.gameObject.SetActive(false);
        }
    }

    public void PianoKey4Collected()
    {
        if (player.checkPianoKey4())
        {
            pianoKey4.gameObject.SetActive(true);
            pianoKey4Empty.gameObject.SetActive(false);
        }
    }

    public void PianoKey5Collected()
    {
        if (player.checkPianoKey5())
        {
            pianoKey5.gameObject.SetActive(true);
            pianoKey5Empty.gameObject.SetActive(false);
        }
    }

    public void MusicBoxPressed()
    {
        musicboxPlaying = true;
        music.violinA.volume = 0.2f;
        music.violinB.volume = 0.2f;
        music.drums.volume = 0.2f;
        music.xyloA.volume = 0.2f;
        music.xyloB.volume = 0.2f;

    }

    public void note1Pressed()
    {
        for(int i = 0; i < playerChoice.Length; i++)
        {
            if(playerChoice[i] == 0)
            {
                playerChoice[i] = 1;
                keysPressed++;
                break;
            }
        }
    }

    public void note2Pressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 2;
                keysPressed++;
                break;
            }
        }
    }

    public void note3Pressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 3;
                keysPressed++;
                break;
            }
        }
    }

    public void note4Pressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 4;
                keysPressed++;
                break;
            }
        }
    }

    public void note5Pressed()
    {
        for (int i = 0; i < playerChoice.Length; i++)
        {
            if (playerChoice[i] == 0)
            {
                playerChoice[i] = 5;
                keysPressed++;
                break;
            }
        }
    }

}
