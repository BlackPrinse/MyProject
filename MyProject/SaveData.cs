using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class SaveData
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public  double Dx { get; set; }
        public  double TimeCount { get; set; }

        public  double[] FirstExprArr { get; set; }
        public  double[] SecExprArr { get; set; }
        public  double[] QValueArr { get; set; }

        public SaveData ()
        {
            Xmin = CalcData.Xmin;
            Xmax = CalcData.Xmax;
            Dx = CalcData.Dx;

            FirstExprArr = CalcData.FirstExprArr;
            SecExprArr = CalcData.SecExprArr;
            QValueArr = CalcData.QValueArr;
        }
    }
}
