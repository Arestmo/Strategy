using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Strategy
{
    class Player
    {
        private string Name;
        private Color Color;
        private bool isAlive;
        private int fieldsCounter;
        private int coins;

        public Player(string name, Color color)
        {
            Name = name;
            Color = color;
            isAlive = true;
            fieldsCounter = 1;
            coins = 1500;
        }

        public bool CheckLife()
        {
            //Funkcja sprawdzająca ilość pól gracza i decydująca o jego życiu lub śmierci. Może zwracać komunikat
            if( fieldsCounter <= 0)
            {
                isAlive = false;
                MessageBox.Show("Player "+ Name +" is now dead! :(");
            }
            return isAlive;
        }

        public void AddField()
        {
            //Funkcja dodająca pole  
            fieldsCounter += 1;
        }

        public void RemoveField()
        {
            //Funckja odejmująca pole
            fieldsCounter -= 1;
        }

        public bool BuySmth(int price)
        {
            if( coins - price > 0)
            {
                coins -= price;
                MessageBox.Show("OK");
                return true;  
            }
            else
            {
                MessageBox.Show("NO");
                return false;
            }
        }

        public Color GetColor()
        {
            return Color;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
