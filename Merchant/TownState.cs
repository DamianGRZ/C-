using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    /// <summary>
    /// Here you can buy products, and sell them
    /// In case you buy you use the town list
    /// In case you sell you use caravan list
    /// </summary>
    public class TownState : State
    {
        public TownState(Merchant merchant) : base(merchant)
        {
            Console.Clear();
            merchant.town.printCityInfo();
            Console.WriteLine();
            Console.WriteLine("Go back to the GameMenu[1]");
            Console.WriteLine("Conduct Trade[2]");
            Console.WriteLine("Show city products[3]");
        }

        public override void ButtonOne()
        {
            merchant.changeState(new GameState(merchant));
        }

        public override void ButtonThree()
        {
            merchant.town.printCityProducts();
        }

        public override void ButtonTwo()
        {
            merchant.changeState(new TradeState(merchant));
        }

        public override void EnterButton()
        {
            Console.WriteLine("Its enter button");
        }

        public override void EscapeButton()
        {
            Console.WriteLine("TS escape");
        }
        public override void Exit()
        {
            Console.WriteLine("Exit");
        }

        public override void KeyBoardInput(string s)
        {
            Console.WriteLine("KeyboardInput");
        }

        public override void TabButton()
        {
            Console.WriteLine("TabButton");
        }
    }
}
