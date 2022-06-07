using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class Caravan
    {
        public string Name { get; set; }
        ItemList ItemList { get; set; }
        public Caravan(string name, ItemList itemList)
        {
            Name = name;
            ItemList = itemList;
        }

        public void BuyProducts(string name, int amount, int size, bool isPossible)// isPossible means the state of the other entity 
                                                                                    // we conduct trade with
        {
            if (isPossible)
            {
                if (ItemList.ContainsItem(name))
                {
                    ItemList.ChangeItemAmount(name, amount);
                }
                else
                {
                    ItemList.AddItem(new Item(name, size, amount));
                }
            }
        }

        public void printCaracanProducts()
        {
            ItemList.DisplayListInfo();
        }

    }
}
