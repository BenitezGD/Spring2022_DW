using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField]
    Image[] inventoryUI;

    Image[] itemList;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        itemList = GetComponent<ItemList>().itemList;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.inventory != null)
        {
            for (int i = 0; i < player.inventory.Length; i++)
            {
                player.inventory[i] = inventoryUI[i];
            }
        }
    }
}
