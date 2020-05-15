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
            Random rand = new Random();
            int value_1 = rand.Next(0, fieldSize);
            int value_2 = rand.Next(0, fieldSize);


            for (int i = 0; i < buttonsTab.GetLength(0); i++)
            {
                for (int j = 0; j < buttonsTab.GetLength(1); j++)
                {
                    Button button = new Button();
                    button.Name = "Field_" + i + "_" + j;
                    button.Size = defaultSize;
                    button.Location = startXY;
                    button.Click += new EventHandler(ButtonClicked);
                    startXY.X += 55;
                    buttonsTab[i, j] = button;
                    Controls.Add(button);
                }
                startXY.Y += 55;
                startXY.X = 50;
            }
            buttonsTab[value_1, value_2].BackColor = Color.Red;

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button button = sender as Button;
                DisplayLabel.Text = button.Name;
                string[] ButtonNameArr = button.Name.ToString().Split('_');
                if (checkField(int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])))
                {
                    buttonsTab[int.Parse(ButtonNameArr[1]), int.Parse(ButtonNameArr[2])].BackColor = Color.Red;
                }
            }

        }

        private bool isRed(Button button)
        {
            if (button.BackColor == Color.Red) return true;
            else return false;
        }

        private bool checkField(int value_i, int value_j)
        {
            //Warunek pole i = 0, j=0

            if(value_i == 0 && value_j == 0)
            {
                if (isRed(buttonsTab[value_i + 1, value_j]) || isRed(buttonsTab[value_i, value_j + 1]) || isRed(buttonsTab[value_i + 1, value_j + 1])) return true;
                else return false;
            }
            if (value_i == 9 && value_j == 9)
            {
                if (isRed(buttonsTab[value_i - 1, value_j]) || isRed(buttonsTab[value_i, value_j - 1]) || isRed(buttonsTab[value_i - 1, value_j - 1])) return true;
                else return false;
            }
            if (value_i == 0 && value_j == 9)
            {
                if (isRed(buttonsTab[value_i , value_j-1]) || isRed(buttonsTab[value_i+1, value_j ]) || isRed(buttonsTab[value_i + 1, value_j - 1])) return true;
                else return false;
            }
            if (value_i == 9 && value_j == 0)
            {
                if (isRed(buttonsTab[value_i - 1, value_j ]) || isRed(buttonsTab[value_i , value_j + 1]) || isRed(buttonsTab[value_i - 1, value_j + 1])) return true;
                else return false;
            }
            if (value_i == 0 && value_j >0 && value_j < 9)
            {
                if (isRed(buttonsTab[value_i , value_j-1]) || isRed(buttonsTab[value_i, value_j + 1]) || isRed(buttonsTab[value_i + 1, value_j ])) return true;
                else return false;
            }
            if (value_i == 9 && value_j > 0 && value_j < 9)
            {
                if (isRed(buttonsTab[value_i, value_j - 1]) || isRed(buttonsTab[value_i, value_j + 1]) || isRed(buttonsTab[value_i - 1, value_j])) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j ==0)
            {
                if (isRed(buttonsTab[value_i-1, value_j]) || isRed(buttonsTab[value_i + 1, value_j]) || isRed(buttonsTab[value_i, value_j + 1])) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j == 9)
            {
                if (isRed(buttonsTab[value_i - 1, value_j]) || isRed(buttonsTab[value_i + 1, value_j]) || isRed(buttonsTab[value_i - 1, value_j - 1])) return true;
                else return false;
            }
            if (value_i > 0 && value_i < 9 && value_j > 0 && value_j < 9)
            {
                if (isRed(buttonsTab[value_i , value_j]) || isRed(buttonsTab[value_i + 1, value_j]) || isRed(buttonsTab[value_i, value_j + 1]) || isRed(buttonsTab[value_i - 1, value_j ]) || isRed(buttonsTab[value_i, value_j - 1]) /*|| isRed(buttonsTab[value_i + 1, value_j + 1]) || isRed(buttonsTab[value_i - 1, value_j - 1]) || isRed(buttonsTab[value_i + 1, value_j - 1]) || isRed(buttonsTab[value_i - 1, value_j + 1])*/) return true;
                else return false;
            }
            return false;








            /*if (value_i < fieldSize && value_j < fieldSize)
            {
                if (buttonsTab[value_i, value_j + 1].BackColor == Color.Red ||
               buttonsTab[value_i, value_j - 1].BackColor == Color.Red ||
               buttonsTab[value_i + 1, value_j].BackColor == Color.Red ||
               buttonsTab[value_i - 1, value_j].BackColor == Color.Red)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (value_i == fieldSize || value_j == fieldSize)
            {
                if (value_i == fieldSize)
                {
                    if (buttonsTab[value_i, value_j + 1].BackColor == Color.Red ||
                         buttonsTab[value_i, value_j - 1].BackColor == Color.Red ||
                         buttonsTab[value_i + 1, value_j].BackColor == Color.Red ||
                          buttonsTab[value_i - 1, value_j].BackColor == Color.Red)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (value_i - 1 < 0 || value_j == fieldSize)
            {
                if (buttonsTab[value_i, value_j + 1].BackColor == Color.Red ||
                buttonsTab[value_i, value_j - 1].BackColor == Color.Red ||
                buttonsTab[value_i + 1, value_j].BackColor == Color.Red)
                {
                    return true;
                }
            }
            else if (value_i == fieldSize || value_j - 1 < 0)
            {
                if (buttonsTab[value_i, value_j + 1].BackColor == Color.Red ||
                buttonsTab[value_i - 1, value_j].BackColor == Color.Red ||
                buttonsTab[value_i + 1, value_j].BackColor == Color.Red)
                {
                    return true;
                }
            }*/

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

        private void FieldForm_Load(object sender, EventArgs e)
        {

        }
    }
}
