using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonmusuType
{
    CowGirl,
    SheepGirl,
    SpiderGirl
}

public enum MonmusuStats
{
    ProductionStat,
    FightingStat
}
public abstract class MonmusuBaseScript : ScriptableObject
{
    public GameObject prefab;
    public MonmusuType type;
    [TextArea(15,10)]
    public string description;
}
