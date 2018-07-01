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

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public PlayerPresenter(IView view)
        {
            this.view = view;
        }

        public void SetPlayerName(string name)
        {
            player.Name = name;
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
            /*if((hitbp==BodyPart.Head&&computer.HP<=15)|| ((hitbp == BodyPart.Body || hitbp == BodyPart.Legs) && computer.HP <= 10))
            {
                computer.GetHit(hitbp);
                computer.HP = 0;
                logger.Info(player.Name+" победил");
            }
            else 
            {

            }*/
            computer.GetHit(hitbp);

            Round++;
        }
    }
}
