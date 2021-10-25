using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka na BMI");
            Console.WriteLine("-----------------");
            Console.WriteLine("napiš tvoji váhu kg:");
            float váha = float.Parse(Console.ReadLine());
            Console.WriteLine("Napiš svoji výšku m:");
            float výška = float.Parse(Console.ReadLine());
            float BMI = váha / (výška * výška);
            Console.WriteLine("výpočet BMI: " + BMI);
            Console.ReadKey();
        }
    }
}
