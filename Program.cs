using System;

namespace folder_3
{
    class Program
    {
        static void Main(string[] args)
        {
           person aaish = new person();
            aaish.fname = "Ayesha";
            aaish.lname = "Shaheen";
            aaish.introduce();
            calculator cal = new calculator();
            float x = cal.add(8,9);
            Console.WriteLine(x);
        }
    }
}
