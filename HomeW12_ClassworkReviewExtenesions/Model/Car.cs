using System;
using System.Collections.Generic;
using System.Text;

namespace HomeW12_ClassworkReviewExtenesions.Model
{
    public class Car
    {
        public static int Speed;

        static Car()
        {
            Speed = 500;
            Console.WriteLine(Speed);
        }

        public static int ShowSpeed()
        {
            return Speed;
        }
    }
}
