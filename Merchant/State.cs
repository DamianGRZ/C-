using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian_Grzesło_Projekt
{
    public abstract class State
    {
        protected Merchant merchant;
        protected Town town;
        public State (Merchant merchant)
        {
            this.merchant = merchant;
            this.town = town;
        }

        public abstract void EnterButton();
        public abstract void EscapeButton();
        public abstract void TabButton();
        public abstract void KeyBoardInput(string s);
        public abstract void Exit();
        public abstract void ButtonOne();
        public abstract void ButtonTwo();
        public abstract void ButtonThree();

    }
}
