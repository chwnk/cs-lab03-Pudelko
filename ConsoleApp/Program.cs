using PudelkoLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pudelko> listOfBoxes = new List<Pudelko>();
            listOfBoxes.Add(new Pudelko(5, 6, 7, UnitOfMeasure.meter));
            listOfBoxes.Add(new Pudelko(33.11, 12.321, 321.12, UnitOfMeasure.centimeter));
            listOfBoxes.Add(new Pudelko(4123, 6423, 4621, UnitOfMeasure.milimeter));
            listOfBoxes.Add(new Pudelko(7, 5, 7, UnitOfMeasure.meter));
            listOfBoxes.Add(new Pudelko(6.234, 4.234));
            listOfBoxes.Add(new Pudelko(1.1234, null, 5.43));
            listOfBoxes.Add(new Pudelko(null, 2.12, null));
            listOfBoxes.Add(new Pudelko(1.45));
            listOfBoxes.Add(new Pudelko());
            listOfBoxes.Add(
                new Pudelko(444, 123, 215, UnitOfMeasure.centimeter).Kompresuj()
            );

            listOfBoxes.Sort();

            listOfBoxes.ForEach(
                (box) =>
                {
                    Console.WriteLine(box);
                }
            );
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("mm"));
        }
    }
}
