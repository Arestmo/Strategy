namespace Strategy
{
    partial class FieldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.NumberOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.GreenTurn = new System.Windows.Forms.RadioButton();
            this.RedTurn = new System.Windows.Forms.RadioButton();
            this.BlueTurn = new System.Windows.Forms.RadioButton();
            this.YellowTurn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(13, 13);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 0;
            this.ButtonGenerate.Text = "Generate Field";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(221, 23);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(79, 13);
            this.DisplayLabel.TabIndex = 1;
            this.DisplayLabel.Text = "Clicked Button:";
            // 
            // NumberOfPlayers
            // 
            this.NumberOfPlayers.Location = new System.Drawing.Point(95, 15);
            this.NumberOfPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumberOfPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPlayers.Name = "NumberOfPlayers";
            this.NumberOfPlayers.Size = new System.Drawing.Size(47, 20);
            this.NumberOfPlayers.TabIndex = 2;
            this.NumberOfPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GreenTurn
            // 
            this.GreenTurn.AutoSize = true;
            this.GreenTurn.BackColor = System.Drawing.Color.Green;
            this.GreenTurn.Enabled = false;
            this.GreenTurn.ForeColor = System.Drawing.Color.Red;
            this.GreenTurn.Location = new System.Drawing.Point(12, 69);
            this.GreenTurn.Name = "GreenTurn";
            this.GreenTurn.Padding = new System.Windows.Forms.Padding(4);
            this.GreenTurn.Size = new System.Drawing.Size(22, 21);
            this.GreenTurn.TabIndex = 5;
            this.GreenTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GreenTurn.UseVisualStyleBackColor = false;
            // 
            // RedTurn
            // 
            this.RedTurn.AutoSize = true;
            this.RedTurn.BackColor = System.Drawing.Color.Red;
            this.RedTurn.Checked = true;
            this.RedTurn.Enabled = false;
            this.RedTurn.ForeColor = System.Drawing.Color.Red;
            this.RedTurn.Location = new System.Drawing.Point(13, 42);
            this.RedTurn.Name = "RedTurn";
            this.RedTurn.Padding = new System.Windows.Forms.Padding(4);
            this.RedTurn.Size = new System.Drawing.Size(22, 21);
            this.RedTurn.TabIndex = 6;
            this.RedTurn.TabStop = true;
            this.RedTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RedTurn.UseVisualStyleBackColor = false;
            // 
            // BlueTurn
            // 
            this.BlueTurn.AutoSize = true;
            this.BlueTurn.BackColor = System.Drawing.Color.Blue;
            this.BlueTurn.Enabled = false;
            this.BlueTurn.ForeColor = System.Drawing.Color.Red;
            this.BlueTurn.Location = new System.Drawing.Point(12, 96);
            this.BlueTurn.Name = "BlueTurn";
            this.BlueTurn.Padding = new System.Windows.Forms.Padding(4);
            this.BlueTurn.Size = new System.Drawing.Size(22, 21);
            this.BlueTurn.TabIndex = 7;
            this.BlueTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlueTurn.UseVisualStyleBackColor = false;
            // 
            // YellowTurn
            // 
            this.YellowTurn.AutoSize = true;
            this.YellowTurn.BackColor = System.Drawing.Color.Yellow;
            this.YellowTurn.Enabled = false;
            this.YellowTurn.ForeColor = System.Drawing.Color.Red;
            this.YellowTurn.Location = new System.Drawing.Point(12, 123);
            this.YellowTurn.Name = "YellowTurn";
            this.YellowTurn.Padding = new System.Windows.Forms.Padding(4);
            this.YellowTurn.Size = new System.Drawing.Size(22, 21);
            this.YellowTurn.TabIndex = 8;
            this.YellowTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YellowTurn.UseVisualStyleBackColor = false;
            // 
            // FieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(357, 372);
            this.Controls.Add(this.YellowTurn);
            this.Controls.Add(this.BlueTurn);
            this.Controls.Add(this.RedTurn);
            this.Controls.Add(this.GreenTurn);
            this.Controls.Add(this.NumberOfPlayers);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.ButtonGenerate);
            this.Name = "FieldForm";
            this.Text = "Strategy";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.NumericUpDown NumberOfPlayers;
        private System.Windows.Forms.RadioButton GreenTurn;
        private System.Windows.Forms.RadioButton RedTurn;
        private System.Windows.Forms.RadioButton BlueTurn;
        private System.Windows.Forms.RadioButton YellowTurn;
    }
}

