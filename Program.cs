using System;

namespace Kondital
{
    class Program
    {
        static void Main(string[] args)
        {
            //save weight, rest pulse and max pulse
            double weight, rPulse, mPulse;
            bool infoInputted = false;
            while(!infoInputted)
            {

                Console.WriteLine("Enter your weight below:");
                string weightStr = Console.ReadLine();

                if(double.TryParse(weightStr, out weight))
                {
                    Console.WriteLine("Enter your resting pulse below:");
                    string pulseStr = Console.ReadLine();

                    if(double.TryParse(pulseStr, out rPulse))
                    {
                        Console.WriteLine("Enter your max pulse below:");
                        string maxPulseStr = Console.ReadLine();

                        if(double.TryParse(maxPulseStr, out mPulse))
                        {
                            infoInputted = true;
                            double kondital = Kondital.BeregnKondital(weight, rPulse, mPulse);
                            double iloptagelse = Kondital.BeregnIloptagelse(kondital, weight);
                            Console.WriteLine($"Success!\nKondital: {kondital}\nIloptagelse: {iloptagelse}");
                        }
                    }
                }

            }

        }
    }

    class Kondital
    {
        public static double BeregnKondital(double weight, double rPulse, double mPulse)
        {
            return (mPulse / rPulse) * 15.3;
        } 

        public static double BeregnIloptagelse(double kondital, double weight)
        {
            return (kondital * weight) / 1000;
        }
    }
}
