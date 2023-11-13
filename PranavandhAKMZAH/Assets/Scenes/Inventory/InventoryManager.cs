using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuActivated;
    public ItemSlot[] itemSlot;
    public ConsumableClass[] itemUsage;
    

    private void Start()
    {
        
    }
    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.E) && menuActivated)
        {
            InventoryMenu.SetActive(false);
            menuActivated = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && !menuActivated)
        {
            InventoryMenu.SetActive(true);
            menuActivated = true;
        }
    }

    public bool UseItem(string itemName)
    {
        for(int i = 0; i < itemUsage.Length; i++)
        {
            if (itemUsage[i].itemName == itemName)
            {
                bool usable = itemUsage[i].UseItem();
                return usable;
            }
            
        }
        return false;
    }
    public int AddItem(string itemName, int quantity, Sprite itemSprite, string itemDescription)
    {
        
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].isFull == false && itemSlot[i].name ==name || itemSlot[i].quantity ==0 )
            {
                int leftOverItems = itemSlot[i].AddItem(itemName, quantity, itemSprite,itemDescription);
                if(leftOverItems > 0)
                {
                    leftOverItems = AddItem(itemName, leftOverItems, itemSprite, itemDescription);
                    
                }
                return leftOverItems;
            }
        }
        return quantity;
    }

    public void DeselectSlot()
    {
        for(int i = 0; i < itemSlot.Length; ++i)
        {
            itemSlot[i].selectedShader.SetActive(false);
            itemSlot[i].thisItemSelected = false;
        }
    }
}

