using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public abstract class Town
    {
        public string Name;

        public Town(string townName)
        {
            Name = townName;
        }

        public abstract void moveCity();
        public abstract void printCityInfo();
        public abstract void printCityProducts();

        public abstract ItemList GetItemList();

        public abstract bool SellProduct(string name, int amount, int size);//Sells product from town
    }
}
