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
        int numbers_of_players=1;
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
                    if(numbers_of_players == 1)
                    {
                        playerTurn = 1;
                        RedTurn.Checked = false;
                        RedTurn.Checked = true;
                    }
                    else
                    {
                        if (IsDead() == 2)
                        {
                            if (IsDead() == 3)
                            {
                                if (IsDead() == 4)
                                {
                                    if (IsDead() == 1)
                                    {
                                        this.Close();

                                    }
                                    else
                                    {
                                        playerTurn = 1;
                                        RedTurn.Checked = true;
                                    }

                                }
                                else
                                {
                                    playerTurn = 1;
                                    YellowTurn.Checked = true;
                                }

                            }
                            else
                            {
                                playerTurn = 1;
                                BlueTurn.Checked = true;
                            }

                        }
                        else
                        {
                            playerTurn = 1;
                            GreenTurn.Checked = true;
                        }
                    }
                    
                }
                else if (GreenTurn.Checked)
                {
                    if (numbers_of_players == 2)
                    {
                        playerTurn = 2;
                        RedTurn.Checked = true;
                    }
                    else
                    {
                        if (IsDead() == 3)
                        {
                            if (IsDead() == 4)
                            {
                                if (IsDead() == 1)
                                {
                                    if (IsDead() == 2)
                                    {
                                        this.Close();

                                    }
                                    else
                                    {
                                        playerTurn = 2;
                                        GreenTurn.Checked = true;
                                    }

                                }
                                else
                                {
                                    playerTurn = 2;
                                    RedTurn.Checked = true;
                                }

                            }
                            else
                            {
                                playerTurn = 2;
                                YellowTurn.Checked = true;
                            }

                        }
                        else
                        {
                            playerTurn = 2;
                            BlueTurn.Checked = true;
                        }
                    }
                }
                else if (BlueTurn.Checked)
                {
                    if (numbers_of_players == 3)
                    {
                        playerTurn = 3;
                        RedTurn.Checked = true;
                    }
                    else
                    {
                        if (IsDead() == 4)
                        {
                            if (IsDead() == 1)
                            {
                                if (IsDead() == 2)
                                {
                                    if (IsDead() == 3)
                                    {
                                        this.Close();

                                    }
                                    else
                                    {
                                        playerTurn = 3;
                                        BlueTurn.Checked = true;
                                    }

                                }
                                else
                                {
                                    playerTurn = 3;
                                    GreenTurn.Checked = true;
                                }

                            }
                            else
                            {
                                playerTurn = 3;
                                RedTurn.Checked = true;
                            }

                        }
                        else
                        {
                            playerTurn = 3;
                            YellowTurn.Checked = true;
                        }
                    }
                }
                else if ( YellowTurn.Checked)
                {
                    if (IsDead() == 1)
                    {
                        if (IsDead() == 2)
                        {
                            if (IsDead() == 3)
                            {
                                if (IsDead() == 4)
                                {
                                    this.Close();

                                }
                                else
                                {
                                    playerTurn = 4;
                                    YellowTurn.Checked = true;
                                }

                            }
                            else
                            {
                                playerTurn = 4;
                                BlueTurn.Checked = true;
                            }

                        }
                        else
                        {
                            playerTurn = 4;
                            GreenTurn.Checked = true;
                        }

                    }
                    else
                    {
                        playerTurn = 4;
                        RedTurn.Checked = true;
                    }
                }

                switch (playerTurn)
                {
                    case 1:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Red))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Red;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Green))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Green;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Blue))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Blue;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (CheckField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2]), Color.Yellow))
                            {
                                buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Yellow;
                            }
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
                        GreenTurn.Visible = false;
                        BlueTurn.Visible = false;
                        YellowTurn.Visible = false;
                        break;
                    }
                case 2:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        buttonsTab[9, 9].BackColor = Color.Green;
                        BlueTurn.Visible = false;
                        YellowTurn.Visible = false;
                        break;
                    }
                case 3:
                    {
                        buttonsTab[0, 0].BackColor = Color.Red;
                        buttonsTab[9, 9].BackColor = Color.Green;
                        buttonsTab[0, 9].BackColor = Color.Blue;
                        YellowTurn.Visible = false;
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
        private bool ColorCheck(Color color)
        {
            int i = 0;
            int j = 0;
            if ( i < 10 )
            {
                if (j < 10)
                {
                    if(buttonsTab[i, j].BackColor == color)
                    {
                        return true;
                    }
                    j++;
                }
                i++;
            }
            return false;
        }
        private int IsDead()
        {
            if (ColorCheck(Color.Red)==false)
            {
                return 1;
            }
            if (ColorCheck(Color.Green) == false)
            {
                return 2;
            }
            if (ColorCheck(Color.Blue) == false)
            {
                return 3;
            }
            if (ColorCheck(Color.Yellow) == false)
            {
                return 4;
            }
            return 0;

        }

    }
}
