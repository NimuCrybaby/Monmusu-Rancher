using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CowGirl", menuName = "Cowgirl")]
public class CowGirlDefault : ItemObject
{
    public int BaseProductionStat;

    public string[] MonMusuNameArray = new string [16];
    public void Awake()
    {
        type = ItemType.CowGirl;
        //MonMusuName = 
    }

    
}
