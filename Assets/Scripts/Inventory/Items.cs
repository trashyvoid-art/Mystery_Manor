using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item Data")]
public class Items : ScriptableObject
{
    public string ItemName;
    public Sprite ItemIcon; //if we want to try to display inv items at some point
    public GameObject prefab;
}
