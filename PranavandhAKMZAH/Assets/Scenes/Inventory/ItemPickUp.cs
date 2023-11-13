using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private string itemName;
    [SerializeField] private int quantity;
    [SerializeField] Sprite sprite;
    [TextArea][SerializeField] string itemDescription;
    public ItemClass itemClass;
    private InventoryManager inventoryManager;


    private void Start()
    {
        Debug.Log(itemClass.itemName);    
        itemName = itemClass.itemName;
        itemDescription = itemClass.itemDescription;
        sprite = itemClass.itemIcon;
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            int leftOverItems = inventoryManager.AddItem(itemName, quantity, sprite, itemDescription);
            if(leftOverItems <= 0)
            {
                Destroy(gameObject);
                
            }
            else
            {
                quantity = leftOverItems;
            }

            Destroy(gameObject);
        }
    }
}
