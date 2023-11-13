using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new ranged class", menuName = "item/ranged")]
public class RangedClass : ItemClass
{
    public override ItemClass GetItem() { return this; }
    public override MeleeClass GetMelee() { return null; }
    public override RangedClass GetRanged() { return this; }
    public override MageClass GetMage() { return null; }
    public override ConsumableClass GetConsumable() { return null; }
}
