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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmPasswordFenerate frmBackColor = new frmPasswordFenerate();
        frmPasswordPorbilities frmPasswordPorbilities = new frmPasswordPorbilities();

        private void Form1_Load(object sender, EventArgs e)
        {
            frmBackColor.MdiParent = this;
            frmBackColor.Dock = DockStyle.Fill;
            frmBackColor.Show();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            frmPasswordPorbilities.Close();
            frmBackColor = new frmPasswordFenerate();
            frmBackColor.MdiParent = this;
            frmBackColor.Dock = DockStyle.Fill;
            frmBackColor.Show();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            frmBackColor.Close();
            frmPasswordPorbilities = new frmPasswordPorbilities();
            frmPasswordPorbilities.MdiParent = this;
            frmPasswordPorbilities.Dock = DockStyle.Fill;
            frmPasswordPorbilities.Show();
        }
    }
}
