using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Expressions
    {
        public static double calcFirstExpr(double xvalue, double qvalue)
        {
            return ((Math.Log(qvalue * Math.Sin(11f * xvalue))) / qvalue);
        }

        public static double calcSecExpr(double xvalue, double qvalue)
        {
            return (Math.Pow((qvalue - xvalue), 1f / 4f));
        }
    }
}
