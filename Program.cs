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
                            Console.WriteLine($"Success! {weight}, {rPulse}, {mPulse}");
                        }
                    }
                }

            }

        }
    }

    class Kondital
    {
        
    }
}
