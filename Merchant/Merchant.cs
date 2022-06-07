using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public class Merchant : Human
    {
        /// <summary>
        /// In this class all the necessary projects are.
        /// The state is responsible for handling different menus
        /// All actions in game happen through player
        /// 
        /// </summary>
        string name;
        public State state;
        public Caravan caravan;//merchant's caravan
        public Town town;//Localization
        public double money;

        public Merchant(Caravan caravan, Town town, int money)
        {
            this.caravan = caravan;
            this.town = town;
            this.state = new MainMenu(this);
            this.money = money;
        }
        public void changeState(State state)
        {
            this.state = state;//change of state

        }

        public void ChangeAccountSelling(double amount)
        {
            money = money + amount;

        }

        public void ChangeAccountBuying(double amount)
        {
            money = money - amount;
        }
        //Oddelegowanie wykonania zadania odpowiedniemu stanowi.

        public void BuyItem()
        {
            //Wywowałnie metody karawany i miasta
        }

        public void SellItem()
        {
            //Wywołanie metody karawany i miasta
        }

        public void MoveTown()
        {
            //Wywołanie metody karawany
        }
        public void EnterButton()
        {
            state.EnterButton();
        }
        public void EscapeButton()
        {
            state.EscapeButton();
        }
        public void TabButton()
        {
            state.TabButton();
        }
        public void KeyBoardInput(string s)
        {
            state.KeyBoardInput(s);
        }
        public void Exit()
        {
            state.Exit();
        }

        public void ButtonOne()
        {
            state.ButtonOne();
        }

        public void ButtonTwo()
        {
            state.ButtonTwo();
        }

        public void ButtonThree()
        {
            state.ButtonThree();
        }
    }
}
