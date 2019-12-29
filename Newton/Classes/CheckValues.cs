using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton.Classes
{
    class CheckValues
    {

        public static double Checking(string radical, string index)
        {
            if (double.TryParse(radical, out double radic) && double.TryParse(index, out double ind))
            {
                return Math.Pow(radic, ind);
            }

            return 0;
        }
    }
}
