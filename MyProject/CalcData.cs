using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class CalcData
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Dx { get; set; }
        public double TimeCount { get; set; }

        public Dictionary<double, double> FirstExpr;
        public Dictionary<double, double> SecExpr;



        public void setDict(CalcDictTO data)
        {
            FirstExpr = data.FirstExpr;
            SecExpr = data.SecExpr;
        }

        public CalcDictTO getDict()
        {
            CalcDictTO data = new CalcDictTO();
            data.FirstExpr = FirstExpr;
            data.SecExpr = SecExpr;
            return data;
        }

        public void setData(CalcTO data)
        {
            Xmin = data.Xmin;
            Xmax = data.Xmax;
            Dx = data.Dx;
        }

        public CalcTO getData()
        {
            CalcTO data = new CalcTO();

            data.Xmin = Xmin;
            data.Xmax = Xmax;
            data.Dx = Dx;
            return data;
        }


    }
}
