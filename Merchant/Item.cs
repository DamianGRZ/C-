using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class Item
    {
        private double buyPrice;
        private double sellPrice;
        private string name;
        private int size;
        private int amount; //amount o product in a given location

        public string Name { get => name; set => name = value; }
        public double BuyPrice { get => buyPrice; set => buyPrice = value; }
        public int Size { get { return size; } }
        public Item(double buyPrice, double sellPrice, string name, int size, int amount)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.amount = amount;
            this.size = size;
        }

        public Item(Item product) //copying constructor
        {
            this.name = product.name;
            this.buyPrice = product.buyPrice;
            this.sellPrice = product.sellPrice;
            this.amount = product.amount;
            this.size = product.size;
        }

        /// <summary>
        /// konstruktor dla produktów z karaw
        /// </summary>
        public Item(string name, int size, int amount)//For caravan products
        {
            this.name = name;
            this.amount = amount;
            this.size = size;
        }

        public void DiplayInfo()
        {
            Console.WriteLine(name + " BuyPrice: " + buyPrice + " SellPrice: " + sellPrice + " Size: " + size + " Amount: " + amount + "\n");
        }

        //Function for decresing, incresing amount of said item in a list, resulted in player
        //buing selling his wares
        public bool ChangeAmount(int amount)//amount can be under/over 0
        {
            if (amount < 0)//To znaczy że od nas ubywa towaru
            {
                if (Math.Abs(amount) > this.amount)
                {
                    Console.WriteLine("Nie możemy wkonać tej transakcji po nieważ ilosc produktu jest zbyt mała\n");
                    return false;
                }
                else
                {
                    this.amount += amount;
                    return true;
                }
            }
            else if (amount == 0)
            {
                Console.WriteLine("This transaction makes no sense, enter number > 0\n");
                this.amount += amount;
                return true;
            }
            else
            {
                this.amount += amount;
                return true;
            }
        }
        //To DO//
        //When buying/selling increase/decrease amount

    }
}
