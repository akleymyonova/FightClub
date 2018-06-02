using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{

    public partial class EntranceForm : Form
    {
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text))
            {
                PlayForm frm = new PlayForm(textBox1.Text);
                this.Hide();
                frm.Show();
            }
            else MessageBox.Show("Wrong input! Try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
