using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
//using System.Xml.Schema;

namespace Foundation_console
{
    class ChooseSystemClass
    {

        public ChooseSystemClass()
        {

        }

   

        //Makes sure that user enters correct number for designated system, example: if there are two systems, query will be repeated
        //until user enters 1 or 2 on numpad
        //Retruns number of planets in selected system
        public int ChooseSystem()
        {
            //Generates scan report (generates systems and planets)
            ScanReport newReport = new ScanReport();
            newReport.systemsScanReport();
            
            //IF statament controlls user input regarding number of planets
            if (ScanReport.NumberOfSystems == 1)
            {
                ConsoleKeyInfo input;
                do
                {
                    Console.Write("Travel to prefferd star system by entering designated number: ");
                    input = Console.ReadKey();
                    Console.WriteLine();
                } while (input.Key != ConsoleKey.NumPad1);
                Console.Clear();

                //Reduce fuel and return number of planets in system
                GameManagement.fuelReduction(ScanReport.FuelCostForFirstSystem);
                return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInFirstSystem;
            }
            else if (ScanReport.NumberOfSystems == 2)
            {
                ConsoleKeyInfo input;
                do
                {
                    Console.Write("Travel to prefferd star system by entering designated number: ");
                    input = Console.ReadKey();
                    Console.WriteLine();
                } while (input.Key != ConsoleKey.NumPad1 && input.Key != ConsoleKey.NumPad2);

                if(input.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForFirstSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInFirstSystem;
                }
                else //input.Key == ConsoleKey.NumPad2
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForSecondSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInSecondSystem;
                }
            }
            else if (ScanReport.NumberOfSystems == 3)
            {
                ConsoleKeyInfo input;
                do
                {
                    Console.Write("Travel to prefferd star system by entering designated number: ");
                    input = Console.ReadKey();
                    Console.WriteLine();
                } while (input.Key != ConsoleKey.NumPad1 && input.Key != ConsoleKey.NumPad2 && input.Key != ConsoleKey.NumPad3);

                if (input.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForFirstSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInFirstSystem;
                }
                else if (input.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForSecondSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInSecondSystem;
                }
                else //input.Key != ConsoleKey.NumPad3
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForThirdSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInThirdSystem;
                }
            }
            else //(s==4)
            {
                ConsoleKeyInfo input;
                do
                {
                    Console.Write("Travel to prefferd star system by entering designated number: ");
                    input = Console.ReadKey();
                    Console.WriteLine();
                } while (input.Key != ConsoleKey.NumPad1 && input.Key != ConsoleKey.NumPad2 && input.Key != ConsoleKey.NumPad3 && input.Key != ConsoleKey.NumPad4);

                if (input.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForFirstSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInFirstSystem;
                }
                else if (input.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForSecondSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInSecondSystem;
                }
                else if (input.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForThirdSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInThirdSystem;
                }
                else // (input.Key != ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    GameManagement.fuelReduction(ScanReport.FuelCostForFourthSystem);
                    return GameManagement.PlanetsInChosenSystem = ScanReport.PlanetsInFourthSystem;
                }
                
            }
        }

       
    }
}
