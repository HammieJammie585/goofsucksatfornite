using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new consumable class", menuName = "item/consumable")]
public class ConsumableClass : ItemClass
{
    public int healthGained;

    public bool UseItem()
    {
       
        Debug.Log("YO CUZ IT WORKED");
        return true;
    }
    public override ItemClass GetItem() { return this; }
    public override MeleeClass GetMelee() { return null; }
    public override RangedClass GetRanged() { return null; }
    public override MageClass GetMage() { return null; }
    public override ConsumableClass GetConsumable() { return this; }
}
