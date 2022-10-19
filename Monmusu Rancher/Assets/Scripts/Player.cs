using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject Monmusu;

    public void AddMonMusu()
    {
        var item = Monmusu.GetComponent<Item>();
        inventory.AddItem(item.item, 1);
        Debug.Log("added monmusu");
    }
}
