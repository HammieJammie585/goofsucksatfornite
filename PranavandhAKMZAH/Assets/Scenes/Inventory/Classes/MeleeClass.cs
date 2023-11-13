using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(fileName ="new melee class", menuName ="item/melee")]
public class MeleeClass : ItemClass
{
    public override ItemClass GetItem() { return this; }
    public override MeleeClass GetMelee() { return this; }
    public override RangedClass GetRanged() { return null; }
    public override MageClass GetMage() { return null; }
    public override ConsumableClass GetConsumable() { return null; }
}
