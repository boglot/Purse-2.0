using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    public class Money : IMoney
    {
        int cash;

        public void SetCash(int a)
        {
            cash = a;
        }
        public int GetCash()
        {
            return cash;
        }
    }
}
