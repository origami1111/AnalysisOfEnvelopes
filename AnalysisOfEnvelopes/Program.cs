using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisOfEnvelopes
{
    class Program
    {
        private static Envelope envelope1 = new Envelope();
        private static Envelope envelope2 = new Envelope();
        static void Main(string[] args)
        {
            string answer;

            do
            {
                setEnvelopValueA();
                setEnvelopValueB();
                setEnvelopValueC();
                setEnvelopValueD();

                switch (envelope1.CompareTo(envelope2))
                {
                    case 1:
                        Console.WriteLine("Конверт 2 может быть вмещен в конверт 1");
                        break;
                    case -1:
                        Console.WriteLine("Конверт 1 может быть вмещен в конверт 2");
                        break;
                    case 0:
                        Console.WriteLine("Конверты не могу быть вмещены друг в друга");
                        break;
                }

                Console.Write("Продолжить ввод(y/yes)? > ");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");

        }

        static void setEnvelopValueA()
        {
            do
            {
                Console.WriteLine("Конверт 1:");
                Console.Write("Параметр a: ");

                try
                {
                    envelope1.A = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (envelope1.A <= 0);
        }
        static void setEnvelopValueB()
        {
            do
            {
                Console.WriteLine("Конверт 1:");
                Console.Write("Параметр b: ");

                try
                {
                    envelope1.B = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (envelope1.B <= 0);
        }
        static void setEnvelopValueC()
        {
            do
            {
                Console.WriteLine("Конверт 2:");
                Console.Write("Параметр c: ");

                try
                {
                    envelope2.A = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (envelope2.A <= 0);
        }
        static void setEnvelopValueD()
        {
            do
            {
                Console.WriteLine("Конверт 2:");
                Console.Write("Параметр a: ");

                try
                {
                    envelope2.B = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (envelope2.B <= 0);
        }
    }
}
