namespace password_generate
{
    partial class frmPasswordFenerate
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
            this.labNum = new System.Windows.Forms.Label();
            this.TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.toggleLowerLetters = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleUppercaseLetters = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleNumbers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleSymbols = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lapPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "password generator";
            // 
            // labNum
            // 
            this.labNum.BackColor = System.Drawing.Color.Transparent;
            this.labNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum.Location = new System.Drawing.Point(347, 229);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(36, 23);
            this.labNum.TabIndex = 3;
            this.labNum.Text = "1";
            // 
            // TrackBar1
            // 
            this.TrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TrackBar1.HoverState.Parent = this.TrackBar1;
            this.TrackBar1.LargeChange = 1;
            this.TrackBar1.Location = new System.Drawing.Point(69, 229);
            this.TrackBar1.Maximum = 20;
            this.TrackBar1.Minimum = 1;
            this.TrackBar1.MouseWheelBarPartitions = 1;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(272, 23);
            this.TrackBar1.TabIndex = 7;
            this.TrackBar1.ThumbColor = System.Drawing.SystemColors.ActiveCaption;
            this.TrackBar1.Value = 1;
            this.TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar1_Scroll);
            // 
            // toggleLowerLetters
            // 
            this.toggleLowerLetters.BackColor = System.Drawing.Color.Transparent;
            this.toggleLowerLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLowerLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLowerLetters.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLowerLetters.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLowerLetters.CheckedState.Parent = this.toggleLowerLetters;
            this.toggleLowerLetters.Location = new System.Drawing.Point(318, 338);
            this.toggleLowerLetters.Name = "toggleLowerLetters";
            this.toggleLowerLetters.ShadowDecoration.Parent = this.toggleLowerLetters;
            this.toggleLowerLetters.Size = new System.Drawing.Size(47, 23);
            this.toggleLowerLetters.TabIndex = 8;
            this.toggleLowerLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLowerLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLowerLetters.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLowerLetters.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLowerLetters.UncheckedState.Parent = this.toggleLowerLetters;
            // 
            // toggleUppercaseLetters
            // 
            this.toggleUppercaseLetters.BackColor = System.Drawing.Color.Transparent;
            this.toggleUppercaseLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleUppercaseLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleUppercaseLetters.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.CheckedState.Parent = this.toggleUppercaseLetters;
            this.toggleUppercaseLetters.Location = new System.Drawing.Point(318, 384);
            this.toggleUppercaseLetters.Name = "toggleUppercaseLetters";
            this.toggleUppercaseLetters.ShadowDecoration.Parent = this.toggleUppercaseLetters;
            this.toggleUppercaseLetters.Size = new System.Drawing.Size(47, 23);
            this.toggleUppercaseLetters.TabIndex = 9;
            this.toggleUppercaseLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleUppercaseLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleUppercaseLetters.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.UncheckedState.Parent = this.toggleUppercaseLetters;
            // 
            // toggleNumbers
            // 
            this.toggleNumbers.BackColor = System.Drawing.Color.Transparent;
            this.toggleNumbers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleNumbers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleNumbers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleNumbers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleNumbers.CheckedState.Parent = this.toggleNumbers;
            this.toggleNumbers.Location = new System.Drawing.Point(318, 430);
            this.toggleNumbers.Name = "toggleNumbers";
            this.toggleNumbers.ShadowDecoration.Parent = this.toggleNumbers;
            this.toggleNumbers.Size = new System.Drawing.Size(47, 23);
            this.toggleNumbers.TabIndex = 10;
            this.toggleNumbers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleNumbers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleNumbers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleNumbers.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleNumbers.UncheckedState.Parent = this.toggleNumbers;
            // 
            // toggleSymbols
            // 
            this.toggleSymbols.BackColor = System.Drawing.Color.Transparent;
            this.toggleSymbols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSymbols.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSymbols.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSymbols.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSymbols.CheckedState.Parent = this.toggleSymbols;
            this.toggleSymbols.Location = new System.Drawing.Point(318, 476);
            this.toggleSymbols.Name = "toggleSymbols";
            this.toggleSymbols.ShadowDecoration.Parent = this.toggleSymbols;
            this.toggleSymbols.Size = new System.Drawing.Size(47, 23);
            this.toggleSymbols.TabIndex = 11;
            this.toggleSymbols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSymbols.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSymbols.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSymbols.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSymbols.UncheckedState.Parent = this.toggleSymbols;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Include Lower Letters(a-z)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Include Uppercase Letters(A-Z)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Include Numbers (1-9)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Include Symbols (@-#)";
            // 
            // lapPassword
            // 
            this.lapPassword.AutoSize = false;
            this.lapPassword.BackColor = System.Drawing.Color.Transparent;
            this.lapPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapPassword.Location = new System.Drawing.Point(69, 158);
            this.lapPassword.Name = "lapPassword";
            this.lapPassword.Size = new System.Drawing.Size(310, 65);
            this.lapPassword.TabIndex = 16;
            this.lapPassword.Text = null;
            this.lapPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::password_generate.Properties.Resources.copy_two_paper_sheets_interface_symbol;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(326, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 43);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(87, 268);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(254, 48);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Generate Password";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmPasswordFenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 605);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lapPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toggleSymbols);
            this.Controls.Add(this.toggleNumbers);
            this.Controls.Add(this.toggleUppercaseLetters);
            this.Controls.Add(this.toggleLowerLetters);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.labNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasswordFenerate";
            this.Text = "form password generate";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPasswordFenerate_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNum;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleLowerLetters;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleUppercaseLetters;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleNumbers;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSymbols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lapPassword;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}