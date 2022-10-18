using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(MonmusuBaseScript _item, int _amount)
    {
        bool hasitem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                hasitem = true;
                break;
            }
        }
        if(!hasitem)
        {
            Container.Add(new InventorySlot(_item, _amount));
        }
    }
}
[System.Serializable]
public class InventorySlot
{
    public MonmusuBaseScript item;
    public int amount;
    public InventorySlot(MonmusuBaseScript _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
}
