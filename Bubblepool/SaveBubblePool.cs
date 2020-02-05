using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class SaveBubblePool : BubblePool
    {
        private string notification;

        public SaveBubblePool(int max) : base(max)
        {

        }

        public override void GetIn(Swimmer joiner)
        {
            base.GetIn(joiner);
        }

        public override void getOut(Swimmer leaver)
        {
            base.getOut(leaver);
        }
    }
}
