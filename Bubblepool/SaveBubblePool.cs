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

        private int dirt;

        public int people;

        public SaveBubblePool(int max, string notification) : base(max)
        {
            notification = "SafeBubblePool cleaned itself automatically!";
        }

        public override void GetIn(Swimmer joiner)
        {
            this.GetDirtier();
            base.GetIn(joiner);
        }

        public override void getOut(Swimmer leaver)
        {
            base.getOut(leaver);
        }

        private void GetDirtier()
        {
            this.dirt++;
            if ((this.dirt == 3))
            {
                this.Clean();
                this.dirt = 0;
                Console.WriteLine(notification);
            }
        }
    }
}
