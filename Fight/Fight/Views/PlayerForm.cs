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
    public partial class PlayerForm : Form,IView
    {
        PlayerPresenter plPresenter ;
        ComputerForm compForm=new ComputerForm();
        
        public static int Value=100;


        public PlayerForm(string Name)
        {
            InitializeComponent();
            plPresenter = new PlayerPresenter(this);
            plPresenter.SetPlayerName(Name);
            PlayerNameLabel.Text = Name;

        }

        public BodyPart Block()
        {
            string temp = Convert.ToString(BlockComboBox.SelectedItem);
            if (temp == "Голова")
                return BodyPart.Head;
            else if (temp == "Ноги")
                return BodyPart.Legs;
            else return BodyPart.Body;
        }

        

        public void ChangeHP(ProgressBar pb, int newValue)
        {
            pb.Value = newValue;
        }

        public BodyPart Hit()
        {
            string temp = Convert.ToString(HitComboBox.SelectedItem);
            if (temp == "Корпус")
                return BodyPart.Body;
            else if (temp == "Ноги")
                return BodyPart.Legs;
            else return BodyPart.Head;
        }
        

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            compForm.Show();
            HitComboBox.SelectedIndex = 1;
            BlockComboBox.SelectedIndex = 1;
            TurnToHit();
        }

        private void HitBut_Click(object sender, EventArgs e)
        {
            plPresenter.Hit();
            plPresenter.SetRound(roundLabel);
            Value = plPresenter.SetComputerHP();
            if (plPresenter.TheEnd == true) TurnTheEnd();
            else
            {
                compForm.Activate();
                TurnToBlock();
            }
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            plPresenter.BeingHit();
            plPresenter.SetRound(roundLabel);
            plPresenter.SetPlayerHP(playerProgressBar);
            if (plPresenter.TheEnd == true) TurnTheEnd();
            else
            TurnToHit();
        }

        private void TurnToHit()
        {
            HitBut.Enabled = true;
            HitComboBox.Enabled = true;
            BlockButton.Enabled = false;
            BlockComboBox.Enabled = false;
        }

        private void TurnToBlock()
        {
            HitBut.Enabled = false;
            HitComboBox.Enabled = false;
            BlockButton.Enabled = true;
            BlockComboBox.Enabled = true;
        }

        private void TurnTheEnd()
        {
            HitBut.Enabled = false;
            HitComboBox.Enabled = false;
            BlockButton.Enabled = false;
            BlockComboBox.Enabled = false;
        }

        private void PlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
