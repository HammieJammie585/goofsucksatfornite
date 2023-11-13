using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuActivated;

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
}

