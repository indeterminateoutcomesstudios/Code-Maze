namespace Lavirint
{
    partial class Questions
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
            this.components = new System.ComponentModel.Container();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Transparent;
            this.buttonA.BackgroundImage = global::Lavirint.Properties.Resources.Yes;
            this.buttonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.ForeColor = System.Drawing.Color.Transparent;
            this.buttonA.Location = new System.Drawing.Point(113, 273);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(74, 70);
            this.buttonA.TabIndex = 0;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            this.buttonA.MouseEnter += new System.EventHandler(this.buttonA_MouseEnter);
            this.buttonA.MouseLeave += new System.EventHandler(this.buttonA_MouseLeave);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Transparent;
            this.buttonB.BackgroundImage = global::Lavirint.Properties.Resources.Yes;
            this.buttonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonB.FlatAppearance.BorderSize = 0;
            this.buttonB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.ForeColor = System.Drawing.Color.Transparent;
            this.buttonB.Location = new System.Drawing.Point(113, 363);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(74, 70);
            this.buttonB.TabIndex = 1;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            this.buttonB.MouseEnter += new System.EventHandler(this.buttonB_MouseEnter);
            this.buttonB.MouseLeave += new System.EventHandler(this.buttonB_MouseLeave);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Transparent;
            this.buttonC.BackgroundImage = global::Lavirint.Properties.Resources.Yes;
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.ForeColor = System.Drawing.Color.Transparent;
            this.buttonC.Location = new System.Drawing.Point(380, 273);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(74, 70);
            this.buttonC.TabIndex = 2;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            this.buttonC.MouseEnter += new System.EventHandler(this.buttonC_MouseEnter);
            this.buttonC.MouseLeave += new System.EventHandler(this.buttonC_MouseLeave);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.Transparent;
            this.buttonD.BackgroundImage = global::Lavirint.Properties.Resources.Yes;
            this.buttonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.ForeColor = System.Drawing.Color.Transparent;
            this.buttonD.Location = new System.Drawing.Point(380, 363);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(74, 70);
            this.buttonD.TabIndex = 3;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            this.buttonD.MouseEnter += new System.EventHandler(this.buttonD_MouseEnter);
            this.buttonD.MouseLeave += new System.EventHandler(this.buttonD_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::Lavirint.Properties.Resources.pozadina_chista;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(797, 517);
            this.ControlBox = false;
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Timer timer1;
    }
}