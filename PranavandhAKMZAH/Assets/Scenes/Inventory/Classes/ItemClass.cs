using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemClass : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    


    public abstract ItemClass GetItem();
    public abstract MeleeClass GetMelee();
    public abstract RangedClass GetRanged();
    public abstract MageClass GetMage();
    public abstract ConsumableClass GetConsumable();
}
