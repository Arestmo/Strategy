using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class FieldForm : Form
    {
        Button[,] buttonsTab;
        Player[] playersTab;

        int fieldSize;
        int playerTurn = 0;
        int numbers_of_players = 1;
        public FieldForm()
        {
            InitializeComponent();

        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            fieldSize = 10;
            Point startXY = new Point(50, 50);
            Size defaultSize = new Size(50, 50);
            buttonsTab = new Button[fieldSize, fieldSize];

            numbers_of_players = Decimal.ToInt32(NumberOfPlayers.Value);

            for (int i = 0; i < buttonsTab.GetLength(0); i++)
            {
                for (int j = 0; j < buttonsTab.GetLength(1); j++)
                {
                    Button button = new Button
                    {
                        Name = "Field_" + i + "_" + j,
                        Size = defaultSize,
                        Location = startXY
                    };
                    button.Click += new EventHandler(ButtonClicked);
                    startXY.X += 55;
                    buttonsTab[i, j] = button;
                    Controls.Add(button);
                }
                startXY.Y += 55;
                startXY.X = 50;
            }

            PlacePlayers(numbers_of_players);
            DisplayLabel.Text = playersTab[playerTurn].GetName() + " TURN ";
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button button = sender as Button;

                string[] ButtonNameArr = button.Name.ToString().Split('_');

                if (playersTab[playerTurn].CheckLife() == true)
                {
                    if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), playersTab[playerTurn].GetColor()))
                    {
                        //Logika sprawdzająca czy pole jest wolne czy "zajęte" jeśli wolne to ok zwiększyć ilość pól gracza AddField, jeśli zajęte to pobrać id gracza z pola i usunąć mu jedno pole RemoveField
                        if (IsFree(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])))
                        {
                            buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = playersTab[playerTurn].GetColor();
                            buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].Text = playersTab[playerTurn].GetName();
                            playersTab[playerTurn].AddField();
                        }
                        else 
                        {
                            int other_player_id = int.Parse(buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].Text);
                            playersTab[other_player_id].RemoveField();
                            buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = playersTab[playerTurn].GetColor();
                            buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].Text = playersTab[playerTurn].GetName();
                            playersTab[playerTurn].AddField();
                        }
                    }
                }
                else
                {
                    numbers_of_players -= 1;
                    for (int i = playerTurn; i < numbers_of_players; i++)
                    {
                        playersTab[playerTurn] = playersTab[playerTurn + 1];

                        //Jesli 2 nie żyje to 
                        //players[2] = null players[2] = players[3]
                    }
                    Array.Resize<Player>(ref playersTab, numbers_of_players);
                }

                playerTurn += 1;
                if (playerTurn >= numbers_of_players)
                    playerTurn = 0;
                DisplayLabel.Text = playersTab[playerTurn].GetName() + " TURN ";

            }

        }

        private bool IsColored(Button button, Color color)
        {
            if (button.BackColor == color) return true;
            else return false;
        }

        private bool CheckField(int value_i, int value_j, Color color)
        {
            bool flag = false;
            try
            {
                if (IsColored(buttonsTab[value_i - 1, value_j], color)) flag = true;
            }
            catch { }
            try
            {
                if (IsColored(buttonsTab[value_i + 1, value_j], color)) flag = true;
            }
            catch { }
            try
            {
                if (IsColored(buttonsTab[value_i, value_j + 1], color)) flag = true;
            }
            catch { }
            try
            {
                if (IsColored(buttonsTab[value_i, value_j - 1], color)) flag = true;
            }
            catch { }
            return flag;

        }

        private bool IsFree(int value_i, int value_j)
        {
            if (buttonsTab[value_i, value_j].BackColor == Control.DefaultBackColor )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.Space)
            {
                DisplayLabel.Text = "SPACJA !";
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PlacePlayers(int number_of_players)
        {
            playersTab = new Player[numbers_of_players];

            Random rand = new Random();

            for (int i = 0; i < numbers_of_players; i++)
            {
                playersTab[i] = new Player(i.ToString(), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            }

            switch (number_of_players)
            {
                case 1:
                    {
                        buttonsTab[0, 0].BackColor = playersTab[0].GetColor();
                        buttonsTab[0, 0].Text = 0.ToString();
                        
                        break;
                    }
                case 2:
                    {
                        buttonsTab[0, 0].BackColor = playersTab[0].GetColor();
                        buttonsTab[0, 0].Text = 0.ToString();
                        buttonsTab[9, 9].BackColor = playersTab[1].GetColor();
                        buttonsTab[9, 9].Text = 1.ToString();
                        break;
                    }
                case 3:
                    {
                        buttonsTab[0, 0].BackColor = playersTab[0].GetColor();
                        buttonsTab[0, 0].Text = 0.ToString();
                        buttonsTab[0, 1].BackColor = playersTab[1].GetColor();
                        buttonsTab[0, 1].Text = 1.ToString();
                        buttonsTab[0, 9].BackColor = playersTab[2].GetColor();
                        buttonsTab[0, 9].Text = 2.ToString();
                        break;
                    }
                case 4:
                    {
                        buttonsTab[0, 0].BackColor = playersTab[0].GetColor();
                        buttonsTab[0, 0].Text = 0.ToString();
                        buttonsTab[9, 9].BackColor = playersTab[1].GetColor();
                        buttonsTab[9, 9].Text = 1.ToString();
                        buttonsTab[0, 9].BackColor = playersTab[2].GetColor();
                        buttonsTab[0, 9].Text = 2.ToString();
                        buttonsTab[9, 0].BackColor = playersTab[3].GetColor();
                        buttonsTab[9, 0].Text = 3.ToString();
                        break;
                    }
            }
        }

    }
}
