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
    }
}
