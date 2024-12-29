using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generate
{
    public partial class frmPasswordFenerate : Form
    {
        public frmPasswordFenerate()
        {
            InitializeComponent();
        }

        private void frmPasswordFenerate_Paint(object sender, PaintEventArgs e)
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


        Random random = new Random();
        private char GenerateRandomChar()
        {
            return ((char)random.Next(32, 126));
        }

        private bool check(char C)
        {
            return ((toggleLowerLetters.Checked == true && (C >= 'a' && C <= 'z')))

            ||

            (toggleUppercaseLetters.Checked == true && (C >= 'A' && C <= 'Z'))

             ||

            (toggleNumbers.Checked == true && (C >= '1' && C <= '9'))

            ||

            (toggleSymbols.Checked == true && ((C >= 32 && C <= 47) || (C >= 58 && C <= 64)
             || (C >= 91 && C <= 96) || (C >= 123 && C <= 126)));
        }
        
        private string GeneratePassword()
        {
            string Password = "";
            int NumberChar = TrackBar1.Value;
            char C;

            for (int i = 0; i < NumberChar; i++)
            {
                do
                {
                     C = GenerateRandomChar();
                } while (!check(C));
                Password += C;
            }

            return Password;
        }

        private void TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (toggleSymbols.Checked == false && toggleNumbers.Checked == false && toggleLowerLetters.Checked == false && toggleUppercaseLetters.Checked == false)
            {
                MessageBox.Show("Please activate one of the options", "Error", MessageBoxButtons.OK);
                TrackBar1.Value = 1;
                    
            }
            else
            {
                labNum.Text = TrackBar1.Value.ToString();
                lapPassword.Text = GeneratePassword();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lapPassword.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (toggleSymbols.Checked == false && toggleNumbers.Checked == false && toggleLowerLetters.Checked == false && toggleUppercaseLetters.Checked == false)
            {
                MessageBox.Show("Please activate one of the options", "Error", MessageBoxButtons.OK);
                TrackBar1.Value = 1;

            }
            else
            {
                lapPassword.Text = GeneratePassword();
            }
        }
    }
}
