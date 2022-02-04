using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class kuriage
    {
        public static int kuriage10(int i)
        {
            decimal a = i;
            int b;
            if (a >= 0)
            {
                b = (int)((Math.Ceiling(a / 10)) * 10);
            }
            else
            {
                b = (int)((Math.Floor(a / 10)) * 10);
            }
            return b;
            
            
        }
    }
}
