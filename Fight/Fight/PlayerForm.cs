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
        ComputerForm compForm = new ComputerForm();
        
        public PlayerForm(string Name)
        {
            InitializeComponent();
            plPresenter = new PlayerPresenter(this);
            plPresenter.SetPlayerName(Name);

        }

        public BodyPart Block()
        {
            string temp = Convert.ToString(BlockComboBox.SelectedValue);
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
            string temp = Convert.ToString(HitComboBox.SelectedValue);
            if (temp == "Корпус")
                return BodyPart.Body;
            else if (temp == "Ноги")
                return BodyPart.Legs;
            else return BodyPart.Head;
        }
        

        private void PlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void HitBut_Click(object sender, EventArgs e)
        {
            plPresenter.Hit();
            plPresenter.SetRound(roundLabel);
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            plPresenter.BeingHit();
            plPresenter.SetRound(roundLabel);
        }
    }
}
