using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SheepGirl", menuName = "Sheepgirl")]
public class SheepGirlDefault : ItemObject
{
    public int BaseProductionStat;
    public void Awake()
    {
        type = ItemType.SheepGirl;
    }
}
