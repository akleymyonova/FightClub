using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NLog.Targets;

namespace Fight
{
    public class PlayerPresenter
    {
        protected IView view;
        Player player=new Player();
        Player computer = new Player("Computer");
        public int Round = 1;
        public bool TheEnd = false;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public PlayerPresenter(IView view)
        {
            this.view = view;
        }

        public void SetPlayerName(string name)
        {
            player.Name = name;
        }

        public int SetComputerHP()
        {
            return computer.HP;
        }

        public void SetPlayerHP(ProgressBar pb)
        {
            pb.Value = player.HP;
        }

        private BodyPart ComputerRandom()
        {
            int bodyPart = new Random().Next(1, 4);
            return (BodyPart)bodyPart;
        }

        public void BeingHit()
        {
            BodyPart blocked = view.Block();
            player.SetBlock(blocked);
            player.GetHit(ComputerRandom());
            Round++;
            logger.Trace("___________");
            if (player.HP == 0) TheEnd = true;

        }

        public void SetRound(Label label)
        {
            label.Text = "Round" + Round;
        }

        private void ComputerBlock()
        {
            computer.SetBlock(ComputerRandom());
        }
        public void Hit()
        {
            ComputerBlock();
            BodyPart hitbp = view.Hit();
            computer.GetHit(hitbp);
            Round++;
            logger.Trace("___________");
            if (computer.HP == 0) TheEnd = true;
        }
    }
}
