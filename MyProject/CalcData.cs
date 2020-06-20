using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    static class CalcData
    {
        public static double Xmin { get; set; }
        public static double Xmax { get; set; }
        public static double Dx { get; set; }
        public static double TimeCount { get; set; }

        public static Dictionary<double, double> FirstExpr;
        public static Dictionary<double, double> SecExpr;


        public static double[] FirstExprArr { get; set; }
        public static double[] SecExprArr { get; set; }
        public static double[] QValueArr { get; set; }
    }
}
