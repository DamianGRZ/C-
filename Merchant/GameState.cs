using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class GameState : State
    {
        public GameState(Merchant merchant) : base(merchant)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game menu\n");
            Console.WriteLine("Enter town[Enter]\n");
            Console.WriteLine("Exit the game [X]\n");
            Console.WriteLine("");
        }

       
        public override void EnterButton()
        {
            merchant.changeState(new TownState(merchant));
        }
        public override void EscapeButton()
        {
            throw new NotImplementedException();
        }

        public override void Exit()
        {
            merchant.changeState(new MainMenu(merchant));
        }

        public override void KeyBoardInput(string s)
        {
            Console.WriteLine(s);
        }

        public override void TabButton()
        {
            throw new NotImplementedException();
        }
        public override void ButtonOne()
        {
            throw new NotImplementedException();
        }

        public override void ButtonThree()
        {
            throw new NotImplementedException();
        }

        public override void ButtonTwo()
        {
            throw new NotImplementedException();
        }

    }
}
