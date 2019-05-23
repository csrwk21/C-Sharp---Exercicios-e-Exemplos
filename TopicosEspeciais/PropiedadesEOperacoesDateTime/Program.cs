using System;

namespace PropiedadesEOperacoesDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            /*
             * 
                        Console.WriteLine(d.ToLongDateString());
                        Console.WriteLine(d.ToLongTimeString());
                        Console.WriteLine(d.ToShortDateString());
                        Console.WriteLine(d.ToShortTimeString());
                        Console.WriteLine(d.ToString());
                        Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
                        Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));



                        Console.WriteLine(d);
                        Console.WriteLine("1) date: "+d.Date);
                        Console.WriteLine("2) day: "+d.Day);
                        Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
                        Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
                        Console.WriteLine("5) Hour: " + d.Hour);
                        Console.WriteLine("6) Kind: " + d.Kind);
                        Console.WriteLine("7) Millisecond: " + d.Millisecond);
                        Console.WriteLine("8) Minute: " + d.Minute);
                        Console.WriteLine("9) Month: " + d.Month);
                        Console.WriteLine("10) Second: " + d.Second);
                        Console.WriteLine("11) Ticks: " + d.Ticks);
                        Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
                        Console.WriteLine("13) Year: " + d.Year);
                        */
        }
    }
}
