using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisOfEnvelopes
{
    class Envelope
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set
            {
                if (a < 0)
                    throw new Exception("Размер должен быть больше 0");
                a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b < 0)
                    throw new Exception("Размер должен быть больше 0");
                b = value;
            }
        }

        public int CompareTo(Envelope other)
        {
            if (a > other.a && b > other.b)
                return 1;
            else if (a < other.a && b < other.b)
                return -1;
            else
                return 0;
        }
    }
}
