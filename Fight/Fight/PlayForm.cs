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
    public partial class PlayForm : Form
    {
        public static string PlayerName;
        public PlayForm(string playerName)
        {
            InitializeComponent();
            PlayerName = playerName;
        }

        Player computer = new Player("Computer",100);
        Player player = new Player(PlayerName, 100);

        private void PlayForm_Load(object sender, EventArgs e)
        {
            label1.Text = PlayerName;
        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
