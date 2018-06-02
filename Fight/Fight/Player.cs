using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    public enum BodyPart
    {
        Head,
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

        public void GetHit(BodyPart bp,Player player)
        {
            int ResPoints;
            if(bp!=player.Blocked)
            {
                if (HP - 10 > 0)
                {
                    if (bp == BodyPart.Head)
                    {
                        if (HP - 15 > 0)
                        {
                            ResPoints = 15;
                            player.HP -= ResPoints;
                            Wound?.Invoke(this, new PlayerEventArgs($"Player {Name} received {ResPoints}", Name, ResPoints));
                        }
                        else
                        {
                            Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, 0));
                        }
                    }
                    else
                    {
                        ResPoints =10;
                        player.HP -= ResPoints;
                        Wound?.Invoke(this, new PlayerEventArgs($"Player {Name} received {ResPoints}",Name,ResPoints));
                    }
                }

                else
                {
                    Death?.Invoke(this, new PlayerEventArgs($"Player {Name} is dead.", Name, 0));
                }
            }
            else
            {
                Block?.Invoke(this, new PlayerEventArgs($"Player {Name} was blocked succsessfully", Name, 0));
            }

        }
    }
}
