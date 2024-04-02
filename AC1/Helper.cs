using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC1
{
    public static class Helper
    {

        public static bool BetweenRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
