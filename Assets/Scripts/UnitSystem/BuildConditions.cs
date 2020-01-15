using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSystem
{
    public static class BuildConditions
    {
        public static bool DependentOnUnits(int a, int b)
        {
            return a > 0 && b > 0;
        }
    }
}
