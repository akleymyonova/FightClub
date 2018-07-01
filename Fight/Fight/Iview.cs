using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{
    public interface IView
    {
        void ChangeHP(ProgressBar pb, int newValue);
        BodyPart Hit();
        BodyPart Block();
    }
}
