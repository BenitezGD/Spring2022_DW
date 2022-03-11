using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XylophonePanel : MonoBehaviour
{
    public Image bigKey;
    public Image smallKey;

    public Button bigKeyMissing;
    public Button smallKeyMissing;

    public PlayerController player;

    public GameObject bigKeySprite;
    public GameObject smallKeySprite;

    public bool puzzleSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bigKey.IsActive() && smallKey.IsActive())
        {
            puzzleSolved = true;
        }
    }

    public void bigKeyCollected()
    {
        if(player.checkBigKey())
        {
            bigKey.gameObject.SetActive(true);
            bigKeyMissing.gameObject.SetActive(false);
            bigKeySprite.SetActive(true);
        }
    }

    public void smallKeyCollected()
    {
        if (player.checkSmallKey())
        {
            smallKey.gameObject.SetActive(true);
            smallKeyMissing.gameObject.SetActive(false);
            smallKeySprite.SetActive(true);
        }
    }
}
