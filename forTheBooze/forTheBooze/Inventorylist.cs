using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTheBooze
{
    internal class Inventorylist
    {
        private Dictionary<string,int> inventory = new Dictionary<string, int>();
        public void AddItem(string item,int quantity)
        {
            inventory.Add(item,quantity);
        }
        public void RemoveItem(string item, int quantity)
        {
            if (inventory.ContainsKey(item))
            {
                inventory[item] -= quantity;
                if (inventory[item] <= 0)
                {
                    inventory.Remove(item);
                }
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item.Key + " " + item.Value + "x");
            }
        }
        public bool CheckItem(string item)
        {
            if (inventory.ContainsKey(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InventoryTyper()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item.Key + " " + item.Value + "x");
            }
        }
        public Dictionary<string, int> GetInventory()
        {
            return inventory;
        }

    }
}
