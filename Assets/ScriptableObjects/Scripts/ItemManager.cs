using UnityEngine;

public class ItemManager : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public bool canStackable;
    public Sprite itemIcon;
    public GameObject itemPrefab;
}
