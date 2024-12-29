using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generate
{
    public partial class frmPasswordPorbilities : Form
    {
        public frmPasswordPorbilities()
        {
            InitializeComponent();
        }

        private void frmPasswordPorbilities_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white, 25);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 40, 70, 280, 70);
            e.Graphics.DrawLine(pen, 40, 70, 40, 400);
            e.Graphics.DrawLine(pen, 40, 400, 280, 400);
            e.Graphics.DrawLine(pen, 280, 400, 280, 70);


            pen = new Pen(white, 225);

            e.Graphics.DrawLine(pen, 160, 70, 160, 400);
        }

        private double probability()
        {
            int Possibilities = 0;
            if (toggleLowerLetters.Checked)
            {
                Possibilities += 26;
            }

            if (toggleUppercaseLetters.Checked)
            {
                Possibilities += 26;
            }

            if (toggleNumbers.Checked)
            {
                Possibilities += 9;
            }

            if (toggleSymbols.Checked)
            {
                Possibilities += 33;
            }

            return Math.Pow((double)Possibilities, (double)(TrackBar1.Value));
        }

        private void FillOutTheLabel()
        {
            if (toggleSymbols.Checked == false && toggleNumbers.Checked == false && toggleLowerLetters.Checked == false && toggleUppercaseLetters.Checked == false)
            {
                MessageBox.Show("Please activate one of the options", "Error", MessageBoxButtons.OK);

            }
            else
            { 
                lapprbabilities.Text = probability().ToString() + "  Possibilities"; 
            }
        }

        private void TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labNum.Text = TrackBar1.Value.ToString();
            FillOutTheLabel();
        }

        private void toggleLowerLetters_CheckedChanged(object sender, EventArgs e)
        {
            FillOutTheLabel();
        }

        private void toggleUppercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            FillOutTheLabel();
        }

        private void toggleNumbers_CheckedChanged(object sender, EventArgs e)
        {
            FillOutTheLabel();
        }

        private void toggleSymbols_CheckedChanged(object sender, EventArgs e)
        {
            FillOutTheLabel();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FillOutTheLabel();
        }

      
    }
}
