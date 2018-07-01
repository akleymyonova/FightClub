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
        Player computer;
        Player player;
        int roundCounter = 1;

        public PlayForm(string playerName)
        {
            InitializeComponent();
            PlayerName = playerName;
            computer = new Player();
            player = new Player(PlayerName);

            player.Block += ShowPlayer;
            player.Death += ShowPlayer;
            player.Wound += ShowPlayer;

            computer.Block += ShowComputer;
            computer.Death += ShowComputer;
            computer.Wound += ShowComputer;
        }

       
        Random rnd = new Random();
        

        

        private void PlayForm_Load(object sender, EventArgs e)
        {
            label1.Text = PlayerName;
            Hello();
        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        void ShowPlayer(object sender, PlayerEventArgs e)
        {
            e.PlayerName = PlayerName;
            e.PlayerHP = player.HP;
            listBox1.Items.Add($"{e.PlayerName} has {e.PlayerHP} Health Points. ");
            listBox1.Items.Add(e.Message);
            playerProgressBar.Value = player.HP;
            //label3.Text = Convert.ToString(e.PlayerName);
        }

        void ShowComputer(object sender, PlayerEventArgs e)
        {
            e.PlayerName = "Computer";
            e.PlayerHP = computer.HP;
            listBox1.Items.Add($"{e.PlayerName} has {e.PlayerHP} Health Points.");
            listBox1.Items.Add(e.Message);
            ComputerProgressBar.Value = computer.HP;
            //label3.Text = Convert.ToString(e.PlayerName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputerHit(BodyPart.Head);

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        void Hello()
        {
            listBox1.Items.Add("Welcome to fight club!");
            listBox1.Items.Add("When there is your turn,");
            listBox1.Items.Add("you must hit a body part of opponent.");

           listBox1.Items.Add("When there is oponent`s turn, you must set block.");
            listBox1.Items.Add("Good luck!");
            listBox1.Items.Add("Your turn is first.");
            listBox1.Items.Add("__________________");
        }

        void PlayerTurn()
        {
            ComBodyBut.Enabled = true;
            ComHeadBut.Enabled = true;
            ComLegsBut.Enabled = true;
            PlBodyBut.Enabled = false;
            PlHeadBut.Enabled = false;
            PlLegsBut.Enabled = false;
        }

        void ComputerTurn()
        {
            ComBodyBut.Enabled = false;
            ComHeadBut.Enabled = false;
            ComLegsBut.Enabled = false;
            PlBodyBut.Enabled = true;
            PlHeadBut.Enabled = true;
            PlLegsBut.Enabled = true;
        }

        void ComputerHit(BodyPart bp)
        {
            roundLabel.Text = "Round " + roundCounter;
            player.SetBlock(bp);
            BodyPart wounded = (BodyPart)rnd.Next(1, 4);
            player.GetHit(wounded);
            roundCounter++;
            listBox1.Items.Add("__________________");
            if (player.HP == 0)
            {
                listBox1.Items.Add(String.Format("Computer wins in {0} rounds. Flawless victory!", roundCounter));
                DialogResult result=MessageBox.Show(String.Format("Computer wins in {0} rounds. Flawless victory!\nDo you want to restart?", roundCounter),"Message",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    computer = new Player();
                    player = new Player(PlayerName);
                    listBox1.Items.Clear();
                    player.Block += ShowPlayer;
                    player.Death += ShowPlayer;
                    player.Wound += ShowPlayer;

                    computer.Block += ShowComputer;
                    computer.Death += ShowComputer;
                    computer.Wound += ShowComputer;

                    ComputerProgressBar.Value = 100;
                    playerProgressBar.Value = 100;
                }
                else
                {
                    ComLegsBut.Enabled = false;
                    ComHeadBut.Enabled = false;
                    ComBodyBut.Enabled = false;
                }
            }
            else
            {
                listBox1.Items.Add("Now is your turn.");
                PlayerTurn();
            }
        }

        void PlayerHit(BodyPart bp)
        {
            roundLabel.Text = "Round " + roundCounter;
            BodyPart blocked = (BodyPart)rnd.Next(1, 4);
            computer.SetBlock(blocked);
            computer.GetHit(bp);
            roundCounter++;
            listBox1.Items.Add("__________________");
            if (computer.HP == 0)
            {
                listBox1.Items.Add(String.Format("You win in {0} rounds. Flawless victory!", roundCounter));
                DialogResult result = MessageBox.Show(String.Format("You win in {0} rounds. Flawless victory!\nDo you want to restart?", roundCounter), "Message", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    computer = new Player();
                    player = new Player(PlayerName);
                    listBox1.Items.Clear();
                    player.Block += ShowPlayer;
                    player.Death += ShowPlayer;
                    player.Wound += ShowPlayer;

                    computer.Block += ShowComputer;
                    computer.Death += ShowComputer;
                    computer.Wound += ShowComputer;

                    ComputerProgressBar.Value = 100;
                    playerProgressBar.Value = 100;
                }
                else
                {
                    PlLegsBut.Enabled = false;
                    PlHeadBut.Enabled = false;
                    PlBodyBut.Enabled = false;
                }
            }
            else
            {
                listBox1.Items.Add("Now is oponent`s turn.");
                ComputerTurn();
            }
        }

        private void PlBodyBut_Click(object sender, EventArgs e)
        {
            ComputerHit(BodyPart.Body);
        }

        private void PlLegsBut_Click(object sender, EventArgs e)
        {
            ComputerHit(BodyPart.Legs);
        }

        private void ComHeadBut_Click(object sender, EventArgs e)
        {
            PlayerHit(BodyPart.Head);
        }

        private void ComBodyBut_Click(object sender, EventArgs e)
        {
            PlayerHit(BodyPart.Body);
        }

        private void ComLegsBut_Click(object sender, EventArgs e)
        {
            PlayerHit(BodyPart.Legs);
        }
    }
}
