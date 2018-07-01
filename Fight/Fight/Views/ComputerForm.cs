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
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
        }

        
        public void ChangeHP(ProgressBar pb, int newValue)
        {
            pb.Value = newValue;
        }

       
        private void ComputerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ComputerForm_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void ComputerForm_Enter(object sender, EventArgs e)
        {
        }

        private void ComputerForm_Activated(object sender, EventArgs e)
        {
            ChangeHP(ComputerProgressBar, PlayerForm.Value);
        }

        private void ComputerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
