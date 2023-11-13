using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new mage class", menuName = "item/mage")]
public class MageClass : ItemClass
{

    public override ItemClass GetItem() { return this; }
    public override MeleeClass GetMelee() { return null; }
    public override RangedClass GetRanged() { return null; }
    public override MageClass GetMage() { return this; }
    public override ConsumableClass GetConsumable() { return null; }
}
