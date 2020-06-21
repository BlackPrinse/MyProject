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
        public double Dx { get; set; }
        public double TimeCount { get; set; }

        public double[] firstArrFunc;
        public double[] firstArrX;

        public double[] secArrFunc;
        public double[] secArrX;
    }
}
