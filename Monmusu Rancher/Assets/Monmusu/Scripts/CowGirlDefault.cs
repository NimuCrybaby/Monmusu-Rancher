using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CowGirl", menuName = "Cowgirl")]
public class CowGirlDefault : MonmusuBaseScript
{
    public int BaseProductionStat;
    public void Awake()
    {
        type = MonmusuType.CowGirl;
    }
}
