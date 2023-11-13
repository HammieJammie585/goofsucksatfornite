using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{

    private InventoryManager inventoryManager;
    //ItemData
    public string itemName;
    public int quantity;
    public Sprite sprite;
    public bool isFull;
    public string itemDescription;
    
    //Item Slot
    [SerializeField] private TMP_Text quantityText;
    [SerializeField] private Image itemImage;

    public GameObject selectedShader;
    public bool thisItemSelected;

    //item description slot
    public Sprite emptySprite;
    public Image itemDescriptionImage;
    public TMP_Text itemDescroptionNametext;
    public TMP_Text itemDescroptionText;

    [SerializeField] int maxNumberofItems;
    private void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }
    public int AddItem(string itemName, int quantity, Sprite sprite, string itemDescription)
    {
        
        {
            // Check to see if the slot is already full
            if (isFull)
            {
                return quantity;
            }
            // Update name
            this.itemName = itemName;
            // update image
            this.sprite = sprite;
            itemImage.sprite = sprite;
            // update description
            this.itemDescription = itemDescription;
            // update amount
            this.quantity += quantity;
            if (this.quantity >= maxNumberofItems)
            {
                quantityText.text = maxNumberofItems.ToString();
                quantityText.enabled = true;
                isFull = true;


                // Return the LEFTOVERS
                int extraItems = this.quantity - maxNumberofItems;
                this.quantity = maxNumberofItems;
                return extraItems;
            }
            // UPDATE AMOUNT TEXT
            quantityText.text = this.quantity.ToString();
            quantityText.enabled = true;

            return 0;
        }
    }

        public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left) 
        {
            OnLeftClick();
        }
        if(eventData.button == PointerEventData.InputButton.Right)
        {

        }
    }
    public void OnLeftClick()
    {
        if (thisItemSelected)
        {
            bool usable = inventoryManager.UseItem(itemName);
            if (usable)
            {
                this.quantity -= 1;
                quantityText.text = this.quantity.ToString();
                if (this.quantity <= 0)
                {
                    EmptySlot();
                }
            }
            
        }
        else
        {
            inventoryManager.DeselectSlot();
            selectedShader.SetActive(true);
            thisItemSelected = true;
            itemDescroptionNametext.text = itemName;
            itemDescroptionText.text = itemDescription;
            itemDescriptionImage.sprite = sprite;
            if (itemDescriptionImage == null)
            {
                emptySprite = itemDescriptionImage.sprite;
            }
        }
        
    }

    private void EmptySlot()
    {
        quantityText.enabled = false;
        itemImage.sprite = emptySprite;
        itemDescroptionNametext.text = "";
        itemDescroptionText.text = "";
        itemDescriptionImage.sprite = emptySprite;
    }
}
