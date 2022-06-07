using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class TradeState : State
    {
        public TradeState(Merchant merchant) : base(merchant)
        {
            Console.Clear();
            Console.WriteLine("Welcome to trade menu\n");
            Console.WriteLine("Sell Products [1]\n");
            Console.WriteLine("Buy Products [2]\n");
            Console.WriteLine("Go back to Town menu [ENTER] \n");
        }

        public override void ButtonOne()
        {
            Console.Clear();
            bool isPossible = true;
            Console.WriteLine("Merchant name: " + merchant.Name);
            Console.WriteLine("Merchant money: " + merchant.money + "\n");
            merchant.caravan.printCaracanProducts();
            Console.WriteLine("What products do you want to sell?\n");
            Console.WriteLine("Type in the whole name");
            string ItemName = Console.ReadLine();

        }

        public override void ButtonTwo()
        {
            Console.Clear();
            bool isPossible = true;
            Console.WriteLine("Merchant name: " + merchant.Name);
            Console.WriteLine("Merchant money: " + merchant.money + "\n");
            merchant.town.printCityProducts();
            Console.WriteLine("What products do you want to buy?\n");
            Console.WriteLine("Type in the whole name");
            ItemList TempList = merchant.town.GetItemList();//Creation of temp list with current town products
            string ItemName = Console.ReadLine();
            if (TempList.ContainsItem(ItemName))
            {
                Console.WriteLine("We have that product, how much do you want: ");
                string amount = Console.ReadLine();
                Console.WriteLine("Are you sure[yes/no]");
                string confirmation = Console.ReadLine();
                if (confirmation == "yes")
                {
                    Item item = TempList.ReturnItem(ItemName);//Returning item with the right name
                    isPossible = merchant.town.SellProduct(item.Name, Int32.Parse(amount), item.Size);
                    merchant.caravan.BuyProducts(item.Name, Int32.Parse(amount), item.Size, isPossible); //Conducts trade
                    merchant.ChangeAccountBuying(Double.Parse(amount) * item.BuyPrice);
                    merchant.caravan.printCaracanProducts();
                    Console.WriteLine("Press [ENTER] to continue");
                    Console.WriteLine("Press [X] to go back to Trade menu");
                    string decision = Console.ReadLine();
                    if(decision == "x" || decision == "X")
                    {
                        EscapeButton();
                    }
                    else
                    {
                        ButtonTwo();
                    }
                    //Dodanie produktu z karawany
                    //Pobranie zapłaty od kupca
                    //Odjęcie produktu z Miasta
                }
            }
            else
            {
                Console.WriteLine("No product with such name, buy something else");
                Console.WriteLine("Press [ENTER] to continue");
                Console.ReadLine();
                ButtonTwo();
            }
        }

        public override void ButtonThree()
        {
            throw new NotImplementedException();
        }

        public override void EnterButton()
        {
            merchant.changeState(new TownState(merchant));
        }

        public override void EscapeButton()
        {
            merchant.changeState(new TradeState(merchant));
        }

        public override void Exit()
        {
            throw new NotImplementedException();
        }

        public override void KeyBoardInput(string s)
        {
            throw new NotImplementedException();
        }

        public override void TabButton()
        {
            throw new NotImplementedException();
        }
    }
}
