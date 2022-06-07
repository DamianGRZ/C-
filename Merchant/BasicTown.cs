using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class BasicTown : Town
    {
        private string name;
        private string level;

        new public string Name { get; set; }
        public string Level { get; set; }

        public Dictionary<string, List<string>> neighbours;
        public ItemList ItemList { get; set; }
        public BasicTown(string name, string level, Dictionary<string, List<string>> neighbours, ItemList ItemList) : base(name)
        {
            this.name = name;
            this.level = level;
            this.neighbours = neighbours;
            this.ItemList = ItemList;
        }

        public override void moveCity()//Do funckji move city podajemy obecną lokacje, mozliwe miejsca podrozy sa dobierane 
                                       //slownika
        {
            Console.WriteLine("What's your next destination?\n");
            int incrementCity = 1;
            foreach (var cityInfo in neighbours[Name])
            {
                string[] allInfo = cityInfo.Split(' ');
                Console.WriteLine("Your " + incrementCity + "st choice is the city of: " + allInfo[0] + " , it's a : " + level + " City\n");
            }
            Console.WriteLine("What is your choice?[1,2,3]");
            Console.ReadLine();
        }

        public override void printCityInfo()
        {
            Console.WriteLine("You are in the city of: " + name + " , it's a : " + level + "\n");
        }

        public override void printCityProducts()
        {
            ItemList.DisplayListInfo();
        }

        public override ItemList GetItemList()
        {
            return ItemList;
        }

        public override bool SellProduct(string name, int amount, int size)
        {
            //Lower or increase products amount
            if (ItemList.ContainsItem(name))
            {
                return ItemList.ChangeItemAmount(name, -amount);
            }
            return false;
        }

    }
}
