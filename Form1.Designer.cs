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
            this.DisplayLabel.Location = new System.Drawing.Point(148, 18);
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
            // FieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(244, 46);
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
    }
}

