using System;

namespace AnalysisOfEnvelopes
{
    class View
    {
        private Envelope envelope1;
        private Envelope envelope2;

        public void SetEnvelopes()
        {
            string answer;

            do
            {
                Console.WriteLine("Конверт 1:");
                envelope1 = new Envelope(GetEnvelopeSideA(), GetEnvelopeSideB());

                Console.WriteLine("Конверт 2:");
                envelope2 = new Envelope(GetEnvelopeSideA(), GetEnvelopeSideB());

                EnvelopeFit();

                Console.Write("Продолжить ввод(y/yes)? > ");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");
        }

        private void EnvelopeFit()
        {
            switch (envelope1.CompareTo(envelope2))
            {
                case 0:
                    Console.WriteLine("Конверты не могут быть вмещены друг в друга");
                    break;
                case 1:
                    Console.WriteLine("Один конверт помещается в другой");
                    break;
            }
        }

        private double GetEnvelopeSideA()
        {
            double sideA = 0.0;
            bool flag = true;

            while (flag)
            {
                Console.Write("Параметр a: ");

                try
                {
                    if (!double.TryParse(Console.ReadLine(), out sideA))
                    {
                        throw new Exception("Неверно введен параметр. Можно вводить только цифры");
                    }
                    if(sideA < 0)
                    {
                        throw new Exception("Сторона не может быть < 0");
                    }

                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return sideA;
            
        }

        private double GetEnvelopeSideB()
        {
            double sideB = 0.0;
            bool flag = true;

            while (flag)
            {
                Console.Write("Параметр b: ");

                try
                {
                    if (!double.TryParse(Console.ReadLine(), out sideB))
                    {
                        throw new Exception("Неверно введен параметр. Можно вводить только цифры");
                    }
                    if (sideB < 0)
                    {
                        throw new Exception("Сторона не может быть < 0");
                    }

                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return sideB;

        }

        private void PrintTask()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Есть два конверта со сторонами (a,b) и (c,d) определить, можно ли один конверт вложить в другой. " +
                "Программа должна обрабатывать ввод чисел с плавающей точкой. " +
                "Программа спрашивает у пользователя размеры конвертов по одному параметру за раз." +
                " После каждого подсчёта программа спрашивает у пользователя хочет ли он продолжить. " +
                "Если пользователь ответит “y” или “yes” (без учёта регистра), программа продолжает работу сначала, " +
                "в противном случае – завершает выполнение.");
            Console.WriteLine("========================================================");
        }
        private void PrintHelp()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Возможные параметры:" +
                "\n-help - выводит информаци. о параметрах" +
                "\n-task - выводит условие задания");
            Console.WriteLine("========================================================");
        }
        public void PrintInstructions(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
            }
            else
            {
                foreach (string str in args)
                {
                    switch (str)
                    {
                        case "-help":
                            PrintHelp();
                            break;
                        case "-task":
                            PrintTask();
                            break;
                        default:
                            Console.WriteLine($"Аргумент '{str}' не найден, или введен неверно!");
                            break;
                    }
                }
            }
        }

        //private void EnvelopeFit()
        //{
        //    switch (IsEnvelopeFit())
        //    {
        //        case false:
        //            Console.WriteLine("Конверты не могут быть вмещены друг в друга");
        //            break;
        //        case true:
        //            Console.WriteLine("Один конверт помещается в другой");
        //            break;
        //    }
        //}

        //public bool IsEnvelopeFit()
        //{
        //    if( (envelope1.A < envelope2.A) && (envelope1.B < envelope2.B) || 
        //        (envelope1.A < envelope2.B) && (envelope1.B < envelope2.A) ||
        //        (envelope2.A < envelope1.A) && (envelope2.B < envelope1.B) ||
        //        (envelope2.A < envelope1.B) && (envelope2.B < envelope1.A))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
