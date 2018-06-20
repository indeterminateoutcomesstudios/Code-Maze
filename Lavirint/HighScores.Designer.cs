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
            this.label6 = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hall of Fame";
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
            this.btnBack.Location = new System.Drawing.Point(472, 337);
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
            this.table.Location = new System.Drawing.Point(206, 159);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.Size = new System.Drawing.Size(272, 140);
            this.table.TabIndex = 7;
            // 
            // lblBr3
            // 
            this.lblBr3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBr3.AutoSize = true;
            this.lblBr3.Location = new System.Drawing.Point(3, 105);
            this.lblBr3.Name = "lblBr3";
            this.lblBr3.Size = new System.Drawing.Size(22, 35);
            this.lblBr3.TabIndex = 6;
            this.lblBr3.Text = "3.";
            this.lblBr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            this.lblTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(87, 70);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(44, 35);
            this.lblTime2.TabIndex = 5;
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBr2
            // 
            this.lblBr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBr2.AutoSize = true;
            this.lblBr2.Location = new System.Drawing.Point(3, 70);
            this.lblBr2.Name = "lblBr2";
            this.lblBr2.Size = new System.Drawing.Size(22, 35);
            this.lblBr2.TabIndex = 3;
            this.lblBr2.Text = "2.";
            this.lblBr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName1
            // 
            this.lblName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName1.AutoSize = true;
            this.lblName1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblName1.Location = new System.Drawing.Point(31, 35);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(50, 35);
            this.lblName1.TabIndex = 1;
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect1
            // 
            this.lblCorrect1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrect1.AutoSize = true;
            this.lblCorrect1.Location = new System.Drawing.Point(137, 35);
            this.lblCorrect1.Name = "lblCorrect1";
            this.lblCorrect1.Size = new System.Drawing.Size(60, 35);
            this.lblCorrect1.TabIndex = 9;
            this.lblCorrect1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect2
            // 
            this.lblCorrect2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrect2.AutoSize = true;
            this.lblCorrect2.Location = new System.Drawing.Point(137, 70);
            this.lblCorrect2.Name = "lblCorrect2";
            this.lblCorrect2.Size = new System.Drawing.Size(60, 35);
            this.lblCorrect2.TabIndex = 10;
            this.lblCorrect2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(31, 70);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(50, 35);
            this.lblName2.TabIndex = 4;
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName3
            // 
            this.lblName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(31, 105);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(50, 35);
            this.lblName3.TabIndex = 7;
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime3
            // 
            this.lblTime3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(87, 105);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(44, 35);
            this.lblTime3.TabIndex = 8;
            this.lblTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong1
            // 
            this.lblWrong1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrong1.AutoSize = true;
            this.lblWrong1.Location = new System.Drawing.Point(203, 35);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(66, 35);
            this.lblWrong1.TabIndex = 11;
            this.lblWrong1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong2
            // 
            this.lblWrong2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrong2.AutoSize = true;
            this.lblWrong2.Location = new System.Drawing.Point(203, 70);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(66, 35);
            this.lblWrong2.TabIndex = 12;
            this.lblWrong2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong3
            // 
            this.lblWrong3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrong3.AutoSize = true;
            this.lblWrong3.Location = new System.Drawing.Point(203, 105);
            this.lblWrong3.Name = "lblWrong3";
            this.lblWrong3.Size = new System.Drawing.Size(66, 35);
            this.lblWrong3.TabIndex = 13;
            this.lblWrong3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect3
            // 
            this.lblCorrect3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrect3.AutoSize = true;
            this.lblCorrect3.Location = new System.Drawing.Point(137, 105);
            this.lblCorrect3.Name = "lblCorrect3";
            this.lblCorrect3.Size = new System.Drawing.Size(60, 35);
            this.lblCorrect3.TabIndex = 14;
            this.lblCorrect3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime1
            // 
            this.lblTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(87, 35);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(44, 35);
            this.lblTime1.TabIndex = 2;
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBr1
            // 
            this.lblBr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBr1.AutoSize = true;
            this.lblBr1.Location = new System.Drawing.Point(3, 35);
            this.lblBr1.Name = "lblBr1";
            this.lblBr1.Size = new System.Drawing.Size(22, 35);
            this.lblBr1.TabIndex = 0;
            this.lblBr1.Text = "1.";
            this.lblBr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wrong";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Correct";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstLevel
            // 
            this.lstLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(200)))), ((int)(((byte)(133)))));
            this.lstLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLevel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 25;
            this.lstLevel.Items.AddRange(new object[] {
            "Easy",
            "Meddium",
            "Hard"});
            this.lstLevel.Location = new System.Drawing.Point(82, 199);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(93, 100);
            this.lstLevel.TabIndex = 8;
            this.lstLevel.SelectedIndexChanged += new System.EventHandler(this.lstLevel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(76, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Select level:";
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::Lavirint.Properties.Resources.Pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(554, 413);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label6;
    }
}