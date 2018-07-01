using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{
    interface IPresenter
    {
        
        void Block(BodyPart bp);
        void Hit(BodyPart bp);
    }
}
