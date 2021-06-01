using System;

namespace AnalysisOfEnvelopes
{
    class Envelope : IComparable<Envelope>
    {
        private double a;
        private double b;
        public double A { get; set; }
        public double B { get; set; }

        public Envelope() { }
        public Envelope(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public int CompareTo(Envelope other)
        {
            if( ((this.A < other.A) && (this.B < other.B)) ||
                ((this.A < other.B) && (this.B < other.A)) ||
                ((other.A < this.A) && (other.B < this.B)) ||
                ((other.A < this.B) && (other.B < this.A)) )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
