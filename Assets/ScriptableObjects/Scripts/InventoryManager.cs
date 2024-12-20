using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
[CreateAssetMenu(fileName = "Inventory",menuName = "ScriptableObjects/Inventory")]
public class InventoryManager : ScriptableObject
{
    public List<Slot> inventorySlots = new List<Slot>();
    public int stackLimit=4;

    public bool AddItem(ItemManager item)
    {
        foreach (Slot slot in inventorySlots)
        {
            if (slot.item==item)
            {
                if (slot.item.canStackable==true)
                {
                    if (slot.itemCount<stackLimit)
                    {
                        slot.itemCount++;
                        if (slot.itemCount>=stackLimit)
                        {
                            slot.isFull = true;
                        }

                        return true;
                    }
                }
            }
            else if(slot.itemCount==0)
            {
                slot.AddItemToSlot(item);
                return true;
            }
        }

        return false;
    }
}

[System.Serializable]

public class Slot
{
    public bool isFull;
    public int itemCount;
    public ItemManager item;

    public void AddItemToSlot(ItemManager item)
    {
        this.item = item;
        
        if (item.canStackable==false)
        {
            isFull = true;
            itemCount++;
            
        }
        else
        {
            itemCount++;
        }
        
        
    }
}