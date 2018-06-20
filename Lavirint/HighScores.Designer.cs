namespace Lavirint
{
    partial class HighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.lblBr3 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblBr2 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblCorrect1 = new System.Windows.Forms.Label();
            this.lblCorrect2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblWrong1 = new System.Windows.Forms.Label();
            this.lblWrong2 = new System.Windows.Forms.Label();
            this.lblWrong3 = new System.Windows.Forms.Label();
            this.lblCorrect3 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblBr1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Scores";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScores.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblScores.Location = new System.Drawing.Point(92, 146);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(0, 33);
            this.lblScores.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Lavirint.Properties.Resources.No;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(560, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 73);
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(200)))), ((int)(((byte)(133)))));
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.lblBr3, 0, 3);
            this.table.Controls.Add(this.lblTime2, 2, 2);
            this.table.Controls.Add(this.lblBr2, 0, 2);
            this.table.Controls.Add(this.lblName1, 1, 1);
            this.table.Controls.Add(this.lblCorrect1, 3, 1);
            this.table.Controls.Add(this.lblCorrect2, 3, 2);
            this.table.Controls.Add(this.lblName2, 1, 2);
            this.table.Controls.Add(this.lblName3, 1, 3);
            this.table.Controls.Add(this.lblTime3, 2, 3);
            this.table.Controls.Add(this.lblWrong1, 4, 1);
            this.table.Controls.Add(this.lblWrong2, 4, 2);
            this.table.Controls.Add(this.lblWrong3, 4, 3);
            this.table.Controls.Add(this.lblCorrect3, 3, 3);
            this.table.Controls.Add(this.lblTime1, 2, 1);
            this.table.Controls.Add(this.lblBr1, 0, 1);
            this.table.Controls.Add(this.label5, 4, 0);
            this.table.Controls.Add(this.label4, 3, 0);
            this.table.Controls.Add(this.label2, 2, 0);
            this.table.Controls.Add(this.label3, 1, 0);
            this.table.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table.ForeColor = System.Drawing.Color.SaddleBrown;
            this.table.Location = new System.Drawing.Point(176, 160);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.table.Size = new System.Drawing.Size(400, 120);
            this.table.TabIndex = 7;
            // 
            // lblBr3
            // 
            this.lblBr3.AutoSize = true;
            this.lblBr3.Location = new System.Drawing.Point(3, 82);
            this.lblBr3.Name = "lblBr3";
            this.lblBr3.Size = new System.Drawing.Size(22, 22);
            this.lblBr3.TabIndex = 6;
            this.lblBr3.Text = "3.";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(87, 51);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(0, 22);
            this.lblTime2.TabIndex = 5;
            // 
            // lblBr2
            // 
            this.lblBr2.AutoSize = true;
            this.lblBr2.Location = new System.Drawing.Point(3, 51);
            this.lblBr2.Name = "lblBr2";
            this.lblBr2.Size = new System.Drawing.Size(22, 22);
            this.lblBr2.TabIndex = 3;
            this.lblBr2.Text = "2.";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblName1.Location = new System.Drawing.Point(31, 20);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(0, 22);
            this.lblName1.TabIndex = 1;
            // 
            // lblCorrect1
            // 
            this.lblCorrect1.AutoSize = true;
            this.lblCorrect1.Location = new System.Drawing.Point(137, 20);
            this.lblCorrect1.Name = "lblCorrect1";
            this.lblCorrect1.Size = new System.Drawing.Size(0, 22);
            this.lblCorrect1.TabIndex = 9;
            // 
            // lblCorrect2
            // 
            this.lblCorrect2.AutoSize = true;
            this.lblCorrect2.Location = new System.Drawing.Point(137, 51);
            this.lblCorrect2.Name = "lblCorrect2";
            this.lblCorrect2.Size = new System.Drawing.Size(0, 22);
            this.lblCorrect2.TabIndex = 10;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(31, 51);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(0, 22);
            this.lblName2.TabIndex = 4;
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(31, 82);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(0, 22);
            this.lblName3.TabIndex = 7;
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(87, 82);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(0, 22);
            this.lblTime3.TabIndex = 8;
            // 
            // lblWrong1
            // 
            this.lblWrong1.AutoSize = true;
            this.lblWrong1.Location = new System.Drawing.Point(266, 20);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(0, 22);
            this.lblWrong1.TabIndex = 11;
            // 
            // lblWrong2
            // 
            this.lblWrong2.AutoSize = true;
            this.lblWrong2.Location = new System.Drawing.Point(266, 51);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(0, 22);
            this.lblWrong2.TabIndex = 12;
            // 
            // lblWrong3
            // 
            this.lblWrong3.AutoSize = true;
            this.lblWrong3.Location = new System.Drawing.Point(266, 82);
            this.lblWrong3.Name = "lblWrong3";
            this.lblWrong3.Size = new System.Drawing.Size(0, 22);
            this.lblWrong3.TabIndex = 13;
            // 
            // lblCorrect3
            // 
            this.lblCorrect3.AutoSize = true;
            this.lblCorrect3.Location = new System.Drawing.Point(137, 82);
            this.lblCorrect3.Name = "lblCorrect3";
            this.lblCorrect3.Size = new System.Drawing.Size(0, 22);
            this.lblCorrect3.TabIndex = 14;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(87, 20);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(0, 22);
            this.lblTime1.TabIndex = 2;
            // 
            // lblBr1
            // 
            this.lblBr1.AutoSize = true;
            this.lblBr1.Location = new System.Drawing.Point(3, 20);
            this.lblBr1.Name = "lblBr1";
            this.lblBr1.Size = new System.Drawing.Size(22, 22);
            this.lblBr1.TabIndex = 0;
            this.lblBr1.Text = "1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wrong Answers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Correct Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // lstLevel
            // 
            this.lstLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(200)))), ((int)(((byte)(133)))));
            this.lstLevel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 25;
            this.lstLevel.Items.AddRange(new object[] {
            "Easy",
            "Meddium",
            "Hard"});
            this.lstLevel.Location = new System.Drawing.Point(75, 160);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(95, 104);
            this.lstLevel.TabIndex = 8;
            this.lstLevel.SelectedIndexChanged += new System.EventHandler(this.lstLevel_SelectedIndexChanged);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::Lavirint.Properties.Resources.Pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(648, 412);
            this.ControlBox = false;
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblBr3;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblBr2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblBr1;
        private System.Windows.Forms.Label lblCorrect1;
        private System.Windows.Forms.Label lblCorrect2;
        private System.Windows.Forms.Label lblWrong1;
        private System.Windows.Forms.Label lblWrong2;
        private System.Windows.Forms.Label lblWrong3;
        private System.Windows.Forms.Label lblCorrect3;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}