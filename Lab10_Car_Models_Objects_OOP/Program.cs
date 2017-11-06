using System;
using System.Collections;

namespace Lab10_Car_Models_Objects_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList availableCars = new ArrayList();
            bool shopping = true;
            availableCars.Add(new Car("Toyota", "Camry", 2018, 31_999));
            availableCars.Add(new Car("Tesla", "Model S", 2017, 42_000));
            availableCars.Add(new Car("Ford", "F150", 2016, 28_000));
            availableCars.Add(new UsedCar("Toyota", "Prius", 2014, 13_999, 72_041));
            availableCars.Add(new UsedCar("Honda", "Civic", 2015, 20_999, 41_743));
            availableCars.Add(new UsedCar("Ford", "Model T", 1927, 15_000, 721_266));


            Console.WriteLine("\tWelcome to Pierce's Car Dealership!\n");
            while (shopping)
            {

                string title = $"    {"Make",-12}{"Model",-10}{"Year",5}{ "Price",8}{"Miles",12}";

                int numberOfCars = Dealership.CarsInTheLot(availableCars, title);
                Console.WriteLine($"{numberOfCars + 1}. Quit");

                Console.WriteLine("\nWhich Car would you like to checkout?");

                int selection = Validator.GetValidSelection($"Select item number from(1 - { numberOfCars + 1}): ", numberOfCars);
                if (selection == numberOfCars + 1)
                {
                    Console.Write("Are you sure you want to quit? (Y/N): ");
                    shopping = !Validator.GetYesorNo();
                    continue;
                }
                Console.WriteLine($"{"Make",-12}{"Model",-10}{"Year",5}{ "Price",8}{"Miles",12}");
                Console.WriteLine(availableCars[selection - 1]);
                
                Console.Write("Would you like to buy this car? (Y/N): ");
                bool buy = Validator.GetYesorNo();
                if (buy)
                {
                    Console.WriteLine($"Congratulations you are the proud owner of a {((Car)availableCars[selection - 1]).Model}!");
                    availableCars.RemoveAt(selection - 1);
                }

                if (availableCars.Count == 0)
                {
                    Console.WriteLine("You bought all the cars!!!!!!!!!!!!!!!!");
                    shopping = false;
                    continue;
                }

                Console.Write("Would you like to keep shopping? (Y/N): ");
                shopping = Validator.GetYesorNo();

            }
            Console.WriteLine("Thank you for shopping at our dealership!");
        }

    }
}
