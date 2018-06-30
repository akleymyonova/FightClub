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
    public partial class PlayerForm : Form
    {
        PlayerController plController = new PlayerController();

        public PlayerForm(string Name)
        {
            InitializeComponent();
            plController.SetPlayerName(Name);

        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
