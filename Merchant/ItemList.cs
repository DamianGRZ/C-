using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class ItemList
    {
        public string Name { get; set; }//Name of the list
        List<Item> Items;//Creates list of items

        public ItemList (string name, List<Item> Items)
        {
            Name = name;
            this.Items = Items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void DisplayListInfo()
        {
            Console.WriteLine(Name);
            foreach (var item in Items)
            {
                item.DiplayInfo();
            }
        }

        public bool ContainsItem(string productName)//Funtion checking if list of items contains product with given name'
        {
            foreach (Item Item in Items)
            {
                if(Item.Name == productName)
                {
                    return true;//If product with such name exist 
                }
            }
            return false;
        }

        public Item ReturnItem(string productName)//Returns Item needed for action
        {
            foreach (Item Item in Items)
            {
                if (Item.Name == productName)
                {
                    return Item;
                }
            }
            return new Item("No Item", 0, 0);
        }

        public bool ChangeItemAmount(string productName, int amount)
        {
            foreach (Item Item in Items)
            {
                if (Item.Name == productName)
                {
                    return Item.ChangeAmount(amount);
                }
            }
            return false;
        }
    }
}
