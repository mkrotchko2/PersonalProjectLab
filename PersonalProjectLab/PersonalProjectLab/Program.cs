using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int MinPress = 15;
            int MaxPress = 140;

            OilReading OilSensor1 = new OilReading(MinPress, MaxPress);

            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("Enter Oil Pressure");
                string input;
                input = Console.ReadLine();
                int OilPress;
                OilPress = int.Parse(input);

                OilSensor1.UpdateOilSensorPress(OilPress);

                OilSensorReading(OilSensor1.CheckOilSensor());

                Console.WriteLine (" Do You Wish to Continue, yes or no?");
                input = Console.ReadLine();

                if (input == "no")
                {
                    _continue = false;   
                }
                Console.WriteLine("Thank You for Using Oil Pressure Test");
            }




        }

        static void OilSensorReading(string EngineSafety)
        {
            Console.WriteLine("Is engine safe?:" + EngineSafety);
        }

       
    }
}