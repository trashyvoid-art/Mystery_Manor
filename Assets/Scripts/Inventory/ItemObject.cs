using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemsData item;

    public void PickupItem()
    {
        Inventory.current.AddItem(item);
    }
}
