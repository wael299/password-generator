namespace password_generate
{
    partial class frmPasswordPorbilities
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lapprbabilities = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleSymbols = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleNumbers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleUppercaseLetters = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleLowerLetters = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.guna2Button1.Location = new System.Drawing.Point(81, 265);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(254, 48);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Number of probabilities";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lapprbabilities
            // 
            this.lapprbabilities.AutoSize = false;
            this.lapprbabilities.BackColor = System.Drawing.Color.Transparent;
            this.lapprbabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapprbabilities.Location = new System.Drawing.Point(63, 155);
            this.lapprbabilities.Name = "lapprbabilities";
            this.lapprbabilities.Size = new System.Drawing.Size(310, 65);
            this.lapprbabilities.TabIndex = 30;
            this.lapprbabilities.Text = null;
            this.lapprbabilities.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Include Symbols (@-#)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Include Numbers (1-9)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Include Uppercase Letters(A-Z)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Include Lower Letters(a-z)";
            // 
            // toggleSymbols
            // 
            this.toggleSymbols.BackColor = System.Drawing.Color.Transparent;
            this.toggleSymbols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSymbols.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSymbols.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSymbols.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSymbols.CheckedState.Parent = this.toggleSymbols;
            this.toggleSymbols.Location = new System.Drawing.Point(312, 473);
            this.toggleSymbols.Name = "toggleSymbols";
            this.toggleSymbols.ShadowDecoration.Parent = this.toggleSymbols;
            this.toggleSymbols.Size = new System.Drawing.Size(47, 23);
            this.toggleSymbols.TabIndex = 25;
            this.toggleSymbols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSymbols.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSymbols.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSymbols.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSymbols.UncheckedState.Parent = this.toggleSymbols;
            this.toggleSymbols.CheckedChanged += new System.EventHandler(this.toggleSymbols_CheckedChanged);
            // 
            // toggleNumbers
            // 
            this.toggleNumbers.BackColor = System.Drawing.Color.Transparent;
            this.toggleNumbers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleNumbers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleNumbers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleNumbers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleNumbers.CheckedState.Parent = this.toggleNumbers;
            this.toggleNumbers.Location = new System.Drawing.Point(312, 427);
            this.toggleNumbers.Name = "toggleNumbers";
            this.toggleNumbers.ShadowDecoration.Parent = this.toggleNumbers;
            this.toggleNumbers.Size = new System.Drawing.Size(47, 23);
            this.toggleNumbers.TabIndex = 24;
            this.toggleNumbers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleNumbers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleNumbers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleNumbers.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleNumbers.UncheckedState.Parent = this.toggleNumbers;
            this.toggleNumbers.CheckedChanged += new System.EventHandler(this.toggleNumbers_CheckedChanged);
            // 
            // toggleUppercaseLetters
            // 
            this.toggleUppercaseLetters.BackColor = System.Drawing.Color.Transparent;
            this.toggleUppercaseLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleUppercaseLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleUppercaseLetters.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.CheckedState.Parent = this.toggleUppercaseLetters;
            this.toggleUppercaseLetters.Location = new System.Drawing.Point(312, 381);
            this.toggleUppercaseLetters.Name = "toggleUppercaseLetters";
            this.toggleUppercaseLetters.ShadowDecoration.Parent = this.toggleUppercaseLetters;
            this.toggleUppercaseLetters.Size = new System.Drawing.Size(47, 23);
            this.toggleUppercaseLetters.TabIndex = 23;
            this.toggleUppercaseLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleUppercaseLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleUppercaseLetters.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleUppercaseLetters.UncheckedState.Parent = this.toggleUppercaseLetters;
            this.toggleUppercaseLetters.CheckedChanged += new System.EventHandler(this.toggleUppercaseLetters_CheckedChanged);
            // 
            // toggleLowerLetters
            // 
            this.toggleLowerLetters.BackColor = System.Drawing.Color.Transparent;
            this.toggleLowerLetters.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLowerLetters.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleLowerLetters.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLowerLetters.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLowerLetters.CheckedState.Parent = this.toggleLowerLetters;
            this.toggleLowerLetters.Location = new System.Drawing.Point(312, 335);
            this.toggleLowerLetters.Name = "toggleLowerLetters";
            this.toggleLowerLetters.ShadowDecoration.Parent = this.toggleLowerLetters;
            this.toggleLowerLetters.Size = new System.Drawing.Size(47, 23);
            this.toggleLowerLetters.TabIndex = 22;
            this.toggleLowerLetters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLowerLetters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleLowerLetters.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleLowerLetters.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleLowerLetters.UncheckedState.Parent = this.toggleLowerLetters;
            this.toggleLowerLetters.CheckedChanged += new System.EventHandler(this.toggleLowerLetters_CheckedChanged);
            // 
            // TrackBar1
            // 
            this.TrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TrackBar1.HoverState.Parent = this.TrackBar1;
            this.TrackBar1.LargeChange = 1;
            this.TrackBar1.Location = new System.Drawing.Point(63, 226);
            this.TrackBar1.Maximum = 20;
            this.TrackBar1.Minimum = 1;
            this.TrackBar1.MouseWheelBarPartitions = 1;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(272, 23);
            this.TrackBar1.TabIndex = 21;
            this.TrackBar1.ThumbColor = System.Drawing.SystemColors.ActiveCaption;
            this.TrackBar1.Value = 1;
            this.TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar1_Scroll);
            // 
            // labNum
            // 
            this.labNum.BackColor = System.Drawing.Color.Transparent;
            this.labNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum.Location = new System.Drawing.Point(341, 226);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(36, 23);
            this.labNum.TabIndex = 20;
            this.labNum.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "password probabilities";
           
            // 
            // frmPasswordPorbilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(414, 558);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lapprbabilities);
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
            this.Name = "frmPasswordPorbilities";
            this.Text = "frmPasswordPorbilities";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPasswordPorbilities_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lapprbabilities;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSymbols;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleNumbers;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleUppercaseLetters;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleLowerLetters;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar1;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Label label1;
    }
}