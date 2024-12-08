using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[System.Serializable]
public class Inventory : MonoBehaviour
{
    [System.Serializable]
    public class Slot
    {
        public string itemName;
        public int count;
        public int maxAllowed;

        public Sprite icon;
        public Slot()
        {
            itemName = "";
            count = 0;
            maxAllowed = 99;
        }

        public bool CanAddItem()
        {
            if (count < maxAllowed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddItem(Item item)
        {
            this.itemName = item.data.itemName;
            this.icon = item.data.icon;
            count++;
        }

        public void RemoveItem()
        {
            count--;
            if (count == 0)
            {
                icon = null;
                itemName = "";
            }
        }
    }

    public List<Slot> slots = new List<Slot>();

    public Inventory(int numSlots)
    {
        for(int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }

    public void Add(Item item)
    {
        foreach(Slot slot in slots)
        {
            if(slot.itemName == item.data.itemName && slot.CanAddItem())
            {
                slot.AddItem(item);
                return;
            }
        }
        foreach(Slot slot in slots)
        {
            if(slot.itemName == "") { 
                slot.AddItem(item);
                return;
            }
        }
    }

   public void Remove(int index)
    {
        slots[index].RemoveItem();
    }
}
