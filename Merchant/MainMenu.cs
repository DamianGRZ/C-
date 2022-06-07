using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Main menu, menu before the game, here we can choose to start the game
//

namespace Damian_Grzesło_Projekt
{
    public class MainMenu : State
    {
        public MainMenu(Merchant merchant) : base(merchant) 
        {
            Console.Clear();
            Console.WriteLine("Welcome to the main menu\n");
            Console.WriteLine("Start the new game [ENTER]\n");
            Console.WriteLine("Load saved game\n");
            Console.WriteLine("Load the FastestRunners[TAB]\n");
            Console.WriteLine("Exit program [X]");
        }

        public override void EnterButton()
        {
            Console.Clear();
            Console.WriteLine("You've choosen to start the new game");
            Console.WriteLine("Enter Payer name: ");
            merchant.Name = Console.ReadLine();
            Console.WriteLine("Now you will be transferred to the gameMenu ");
            merchant.changeState(new GameState(merchant));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("TS escape");
        }
        public override void Exit()
        {
            Environment.Exit(0);
        }

        public override void KeyBoardInput(string s)
        {
            Console.WriteLine("KeyboardInput");
        }

        public override void TabButton()
        {
            Console.Clear();
            Console.WriteLine("These are the fastest runners:");
            Console.WriteLine("Type Enter to exit");
            Console.ReadLine();
            merchant.changeState(new MainMenu(merchant));
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
