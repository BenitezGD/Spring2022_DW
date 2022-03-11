using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRooms : MonoBehaviour
{
    public int sceneNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (sceneNum == 1 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_2");
        }

        if (sceneNum == 2 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_3");
        }

        if (sceneNum == 3 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_4");
        }

        if (sceneNum == 4 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_5");
        }

        if (sceneNum == 5 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_6");
        }

        if (sceneNum == 6 && other.tag == "Player")
        {
            SceneManager.LoadScene("Room_1");
        }
    }
}
