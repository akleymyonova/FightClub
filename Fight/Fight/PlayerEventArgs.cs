using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class PlayerEventArgs
    {
        public string Message { get; set; }
        public string PlayerName { get; set; }
        public int PlayerHP { get; set; }

        public PlayerEventArgs(string message, string name, int hp)
        {
            Message = message;
            PlayerName = name;
            PlayerHP = hp;
        }

    }
}
