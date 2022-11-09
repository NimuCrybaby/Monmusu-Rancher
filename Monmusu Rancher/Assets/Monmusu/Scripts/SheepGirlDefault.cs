using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SheepGirl", menuName = "Sheepgirl")]
public class SheepGirlDefault : MonmusuBaseScript
{
    public int BaseProductionStat;
    public void Awake()
    {
        type = MonmusuType.SheepGirl;
    }
}
