using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    public class BubblePool
    {
        private List<Swimmer> people = new List<Swimmer>();

        private int max;

        private int dirt;

        public BubblePool(int max)
        {
            this.max = max;
            this.dirt = 0;
        }

        public void GetIn(Swimmer joiner)
        {
            this.people.Add(joiner);
            this.GetDirtier();
        }

        public void getOut(Swimmer leaver)
        {
            this.people.Remove(leaver);
            this.GetDirtier();
        }

        public void Clean()
        {
            this.people.Clear();
            this.dirt = 0;
        }

        private void GetDirtier()
        {
            this.dirt++;
            if ((this.dirt == this.max))
            {
                throw new PoolDirtyException("Pool became dirty!");
            }
        }
    }
}

namespace Simhall
{
    public class PoolDirtyException : Exception
    {
        public PoolDirtyException(String s) :
                    base(s)
        {

        }
    }
}
