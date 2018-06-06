using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public event PlayerHandler Block;
        public event PlayerHandler Death;
        public event PlayerHandler Wound;

        public Player()
        {
            Name = "Computer";
            HP = 100;
        }
        public Player(string name,int hp)
        {
            Name = name;
            HP = hp;
        }

        public void SetBlock(BodyPart bp)
        {
            Blocked = bp;
        }

        public void GetHit(BodyPart bp)
        {
            int ResPoints;
            if(bp!=Blocked)
            {
                if (HP - 10 > 0)
                {
                    if (bp == BodyPart.Head)
                    {
                        if (HP - 15 > 0)
                        {
                            ResPoints = 15;
                            HP -= ResPoints;
                            Wound?.Invoke(this, new PlayerEventArgs(String.Format("Player {0} received minus {1} points, wounded {2}",Name,ResPoints,bp), Name, ResPoints,HP));
                        }
                        else
                        {
                            HP = 0;
                            Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, HP,HP));
                        }
                    }
                    else
                    {
                        ResPoints =10;
                        HP -= ResPoints;
                        Wound?.Invoke(this, new PlayerEventArgs(String.Format("Player {0} received minus {1} points, wounded {2}", Name, ResPoints, bp), Name, ResPoints, HP));
                    }
                }

                else
                {
                    HP = 0;
                    Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, HP,HP));
                }
            }
            else
            {
                Block?.Invoke(this, new PlayerEventArgs($"Player {Name} was blocked succsessfully", Name, 0,HP));
            }

        }
    }
}
