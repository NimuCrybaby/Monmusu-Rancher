using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject CowGirl;
    public GameObject SheepGirl;

    public void AddCowGirl()
    {
        var item = CowGirl.GetComponent<Item>();
        inventory.AddItem(item.item, 1);
        Debug.Log("added cowgirl");
    }

     public void AddSheepGirl()
    {
        var item = SheepGirl.GetComponent<Item>();
        inventory.AddItem(item.item, 1);
        Debug.Log("added sheepgirl");
    }
}
