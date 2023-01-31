using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int CashMoney = 0;
    public InventoryObject inventory;
    public GameObject CowGirlItemObject;

    public void GetMonmusu()
    {
        var item = CowGirlItemObject.GetComponent<MonMusuItem>();
        Item _item = new Item(item.item);
            Debug.Log(_item.Id);
            inventory.AddItem(_item, 1);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            inventory.Load();
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Items = new InventorySlot[28];
    }
}
