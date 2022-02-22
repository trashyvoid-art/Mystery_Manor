using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory current = null;
    private List<Items> itemList;

    private void Awake()
    {
        if (current == null)
            current = this;
        else if (current != this)
        { Destroy(gameObject); }
        itemList = new List<Items>();
    }
    public void AddItem(ItemsData itemsdata)
    {
        Items newItem = new Items();
        Console.Log("added" + newItem.ItemName + "item");
        itemList.Add(newItem);
    }

    public void RemoveItem()
    {
        //come back to this later;; lazy
        //itemList.Remove();
    }

    public bool RemoveItemAtIndex(int index) //removes item at specified index
    {
        if (index < 0 || index > itemList.Count)
        {
            Console.Log("index is less than 0 or over itemList.Count");
            return false;
        }
        else
        {
            Console.Log("item removed");
            itemList.RemoveAt(index);
            return true;
        }
    }

    //if you want to try to add UI code yell at Alex if you need help or someone who is suited for UI stuff
}
