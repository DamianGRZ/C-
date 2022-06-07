using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class Program
    {
        static bool isPlay;
        static void Main(string[] args)
        {
            isPlay = true;
            Item apple = new Item(2.12, 1.98, "Apple", 2, 10);
            Item banana = new Item(2.60, 2.10, "Banana", 2, 10);
            List<string> locations;
            locations = new List<string>();
            locations.Add("kaka Basic");
            Dictionary<string, List<string>> neighbours = new Dictionary<string, List<string>>();
            neighbours.Add("abbs", locations);

            List<Item> townItems = new List<Item>();
            List<Item> caravanItems = new List<Item>();

            ItemList list = new ItemList("abbsTownList", townItems);
            list.AddItem(apple);
            list.AddItem(banana);
            ItemList CaravanList = new ItemList("CaravanProducts", caravanItems);

            BasicTown town = new BasicTown("abbs", "Basic", neighbours,list);
            Caravan caravan = new Caravan("MyCaravan", CaravanList);

            ConsoleKeyInfo key;
            Merchant merchant = new Merchant(caravan, town, 1000);
            while (isPlay)
            { 
                key = Console.ReadKey(true);
                switch (key.Key.ToString())
                {
                    case "X": merchant.Exit(); break;
                    case "Enter": merchant.EnterButton(); break;
                    case "Escape": merchant.EscapeButton(); break;
                    case "Tab": merchant.TabButton(); break;
                    case "D1": merchant.ButtonOne(); break;
                    case "D2": merchant.ButtonTwo(); break;
                    case "D3": merchant.ButtonThree(); break;
                    default: merchant.KeyBoardInput(key.Key.ToString()); break;
                }
            }
            Console.ReadLine();
        }
    }
}
