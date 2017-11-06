using System;
using System.Collections;

namespace Lab10_Car_Models_Objects_OOP
{
    class Dealership
    {
        public static int CarsInTheLot(ArrayList availableCars, string title)
        {
            Console.WriteLine(title);
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            int numberOfCars = 0;
            foreach (Car car in availableCars)
            {
                numberOfCars++;
                Console.WriteLine($"{numberOfCars}. {car}");

            }

            return numberOfCars;
        }
    }
}
