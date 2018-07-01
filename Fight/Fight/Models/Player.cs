using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Targets;

namespace Fight
{
    public enum BodyPart
    {
        Head=1,
        Body,
        Legs
    }

    class Player
    {
        public string Name { get; set; }
        public BodyPart Blocked { get; set; }
        public int HP { get; set; }

        

        public delegate void PlayerHandler(object sender, PlayerEventArgs e);

        
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public event PlayerHandler Block;
        public event PlayerHandler Death;
        public event PlayerHandler Wound;

        public Player()
        {
            Name = " ";
            HP = 100;
        }
        public Player(string name)
        {
            Name = name;
            HP = 100;
        }

        public void SetBlock(BodyPart bp)
        {switch (bp) {
                case BodyPart.Body:
                    logger.Debug(Name+" защищает корпус.");
                    break;
                case BodyPart.Head:
                    logger.Debug(Name+" защищает голову.");
                    break;
                case BodyPart.Legs:
                    logger.Debug(Name+" защищает ноги.");
                    break;
                    
            }
            Blocked = bp;
        }

        public void GetHit(BodyPart bp)
        {
            logger.Debug("Игрока "+Name+" бьют.");
            int ResPoints;
            if(bp!=Blocked)
            {
                logger.Info("Блокирование не помогло от удара.");
                if (HP - 10 > 0)
                {
                    if (bp == BodyPart.Head)
                    {
                        logger.Trace("Соперник бъет в голову.");
                        if (HP - 15 > 0)
                        {
                            ResPoints = 15;
                            HP -= ResPoints;
                            Wound?.Invoke(this, new PlayerEventArgs(String.Format("Player {0} received minus {1} points, wounded {2}",Name,ResPoints,bp), Name, ResPoints,HP));
                            logger.Trace(Name+" получил минус 15 очков.");
                            logger.Trace("Оставшееся здоровье: " + HP);
                        }
                        else
                        {
                            logger.Info(Name+" проиграл.");
                            HP = 0;
                            Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, HP,HP));
                        }
                    }
                    else
                    {
                        if (bp == BodyPart.Body)
                            logger.Trace("Соперник бъет в корпус.");
                        else logger.Trace("Соперник бъет в ноги.");
                        ResPoints =10;
                        HP -= ResPoints;
                        logger.Trace(Name+" получил минус 10 очков.");
                        logger.Trace("Оставшееся здоровье: " + HP);
                        Wound?.Invoke(this, new PlayerEventArgs(String.Format("Player {0} received minus {1} points, wounded {2}", Name, ResPoints, bp), Name, ResPoints, HP));
                    }
                }

                else
                {
                    logger.Info(Name+" проиграл.");
                    HP = 0;
                    Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, HP,HP));
                }
            }
            else
            {
                logger.Debug("Повезло! Блокирование спасло от удара.");
                logger.Trace("Оставшееся здоровье: " + HP);
                Block?.Invoke(this, new PlayerEventArgs($"Player {Name} was blocked succsessfully", Name, 0,HP));
            }

        }
    }
}
