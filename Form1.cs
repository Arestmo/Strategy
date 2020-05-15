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
        int fieldSize;
        int playerTurn = 0;
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

            int numbers_of_players = Decimal.ToInt32(NumberOfPlayers.Value);

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


        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button button = sender as Button;
                DisplayLabel.Text = button.Name;
                string[] ButtonNameArr = button.Name.ToString().Split('_');

                if(RedTurn.Checked)
                {
                    playerTurn = 1;
                }
                else if (GreenTurn.Checked)
                {
                    playerTurn = 2;
                }
                else if (BlueTurn.Checked)
                {
                    playerTurn = 3;
                }
                else if ( YellowTurn.Checked)
                {
                    playerTurn = 4;
                }

                switch (playerTurn)
                {
                    case 1:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Red))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Red;
                            }
                            GreenTurn.Checked = true;
                            break;
                        }
                    case 2:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Green))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Green;
                            }
                            BlueTurn.Checked = true;
                            break;
                        }
                    case 3:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Blue))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Blue;
                            }
                            YellowTurn.Checked = true;
                            break;
                        }
                    case 4:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Yellow))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Yellow;
                            }
                            RedTurn.Checked = true;
                            break;
                        }
                }

            }

        }

        private bool IsColored(Button button, Color color)
        {
            if (button.BackColor == color) return true;
            else return false;
        }

        private bool CheckField(int value_i, int value_j, Color color)
        {
            //Warunek pole i = 0, j=0

            if (value_i == 0 && value_j == 0)
            {
                if (IsColored(buttonsTab[value_i + 1, value_j], color) || IsColored(buttonsTab[value_i, value_j + 1], color) || IsColored(buttonsTab[value_i + 1, value_j + 1], color)) return true;
                else return false;
            }
            if (value_i == 9 && value_j == 9)
            {
                if (IsColored(buttonsTab[value_i - 1, value_j], color) || IsColored(buttonsTab[value_i, value_j - 1], color) || IsColored(buttonsTab[value_i - 1, value_j - 1], color)) return true;
                else return false;
            }
            if (value_i == 0 && value_j == 9)
            {
                if (IsColored(buttonsTab[value_i, value_j - 1], color) || IsColored(buttonsTab[value_i + 1, value_j], color) || IsColored(buttonsTab[value_i + 1, value_j - 1], color)) return true;
                else return false;
            }
            if (value_i == 9 && value_j == 0)
            {
                if (IsColored(buttonsTab[value_i - 1, value_j], color) || IsColored(buttonsTab[value_i, value_j + 1], color) || IsColored(buttonsTab[value_i - 1, value_j + 1], color)) return true;
                else return false;
            }
            if (value_i == 0 && value_j > 0 && value_j < 9)
            {
                if (IsColored(buttonsTab[value_i, value_j - 1], color) || IsColored(buttonsTab[value_i, value_j + 1], color) || IsColored(buttonsTab[value_i + 1, value_j], color)) return true;
                else return false;
            }
            if (value_i == 9 && value_j > 0 && value_j < 9)
            {
                if (IsColored(buttonsTab[value_i, value_j - 1], color) || IsColored(buttonsTab[value_i, value_j + 1], color) || IsColored(buttonsTab[value_i - 1, value_j], color)) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j == 0)
            {
                if (IsColored(buttonsTab[value_i - 1, value_j], color) || IsColored(buttonsTab[value_i + 1, value_j], color) || IsColored(buttonsTab[value_i, value_j + 1], color)) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j == 9)
            {
                if (IsColored(buttonsTab[value_i - 1, value_j], color) || IsColored(buttonsTab[value_i + 1, value_j], color) || IsColored(buttonsTab[value_i, value_j - 1], color)) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j > 0 && value_j < 9)
            {
                if (IsColored(buttonsTab[value_i, value_j], color) || IsColored(buttonsTab[value_i + 1, value_j], color) || IsColored(buttonsTab[value_i, value_j + 1], color) || IsColored(buttonsTab[value_i - 1, value_j], color) || IsColored(buttonsTab[value_i, value_j - 1], color) /*|| IsColored(buttonsTab[value_i + 1, value_j + 1]) || IsColored(buttonsTab[value_i - 1, value_j - 1]) || IsColored(buttonsTab[value_i + 1, value_j - 1]) || IsColored(buttonsTab[value_i - 1, value_j + 1])*/) return true;
                else return false;
            }
            return false;

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
            switch (number_of_players)
            {
                case 1:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        break;
                    }
                case 2:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        buttonsTab[9, 9].BackColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        buttonsTab[9, 9].BackColor = Color.Green;
                        buttonsTab[0, 9].BackColor = Color.Blue;
                        break;
                    }
                case 4:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        buttonsTab[9, 9].BackColor = Color.Green;
                        buttonsTab[0, 9].BackColor = Color.Blue;
                        buttonsTab[9, 0].BackColor = Color.Yellow;
                        break;
                    }
            }
        }

    }
}
