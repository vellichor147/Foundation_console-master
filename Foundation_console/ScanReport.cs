using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    //This class retrives data for scan report and prints it 
    class ScanReport
    {
        private static int numberOfSystems;
        private static int planetsInFirstSystem;
        private static int planetsInSecondSystem;
        private static int planetsInThirdSystem;
        private static int planetsInFourthSystem;

        private static int fuelCostForFirstSystem;
        private static int fuelCostForSecondSystem;
        private static int fuelCostForThirdSystem;
        private static int fuelCostForFourthSystem;

        public ScanReport()
        {

        }

      
        
        //Generates scan report (generates systems and planets)
        public void systemsScanReport()
        {
            //Gets number of systems from Scan class
            //numberOfSystems = 4;  //for test only!!
            numberOfSystems = Scan.generateSystems();

            //Depending on number of discovered systems (sysNum) if-else statement prints information about system/s
            if (numberOfSystems == 1)
            {
                //Retrive number of generated planets and fuel cost for first (and only) system
                planetsInFirstSystem = generatePlanets();
                fuelCostForFirstSystem = fuelRequired();

                //Console.WriteLine("Fuel: " + GameManagement.MainFuel);
                //Console.WriteLine("Probes: {0}", GameManagement.ProbeNumber);

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("There is only " + numberOfSystems + " star system that is close enough for travel.");
                Console.WriteLine("This star system consists of " + planetsInFirstSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForFirstSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForFirstSystem) + Environment.NewLine);
                
            }
            else if (numberOfSystems == 2)
            {
                //Retrive number of generated planets and fuel costs for 2 systems
                planetsInFirstSystem = generatePlanets();
                planetsInSecondSystem = generatePlanets();

                fuelCostForFirstSystem = fuelRequired();
                fuelCostForSecondSystem = fuelRequired();

                //Console.WriteLine("Fuel: " + GameManagement.MainFuel);
                //Console.WriteLine("Probes: {0}", GameManagement.ProbeNumber);
                //Console.WriteLine(Environment.NewLine);
                Console.WriteLine("There are " + numberOfSystems + " star systems that are close enough for travel." + Environment.NewLine);
               
                Console.WriteLine("1. Star system");
                Console.WriteLine("This star system consists of " + planetsInFirstSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForFirstSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForFirstSystem) + Environment.NewLine);

                Console.WriteLine("2. Star system");
                Console.WriteLine("This star system consists of " + planetsInSecondSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForSecondSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForSecondSystem) + Environment.NewLine);
            }
            else if(numberOfSystems == 3)
            {
                //Retrive number of generated planets and fuel costs for 3 systems
                planetsInFirstSystem = generatePlanets();
                planetsInSecondSystem = generatePlanets();
                planetsInThirdSystem = generatePlanets();

                fuelCostForFirstSystem = fuelRequired();
                fuelCostForSecondSystem = fuelRequired();
                fuelCostForThirdSystem = fuelRequired();

                //Console.WriteLine("Fuel: " + GameManagement.MainFuel);
                //Console.WriteLine("Probes: {0}", GameManagement.ProbeNumber);
                //Console.WriteLine(Environment.NewLine);
                Console.WriteLine("There are " + numberOfSystems + " star systems that are close enough for travel." + Environment.NewLine);
               
                Console.WriteLine("1. Star system");
                Console.WriteLine("This star system consists of " + planetsInFirstSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForFirstSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForFirstSystem) + Environment.NewLine);

                Console.WriteLine("2. Star system");
                Console.WriteLine("This star system consists of " + planetsInSecondSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForSecondSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForSecondSystem) + Environment.NewLine);

                Console.WriteLine("3. Star system");
                Console.WriteLine("This star system consists of " + planetsInThirdSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForThirdSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForThirdSystem) + Environment.NewLine);
            }
            else if (numberOfSystems == 4)
            {
                planetsInFirstSystem = generatePlanets();
                planetsInSecondSystem = generatePlanets();
                planetsInThirdSystem = generatePlanets();
                planetsInFourthSystem = generatePlanets();

                fuelCostForFirstSystem = fuelRequired();
                fuelCostForSecondSystem = fuelRequired();
                fuelCostForThirdSystem = fuelRequired();
                fuelCostForFourthSystem = fuelRequired();


                //Console.WriteLine("Fuel: " + GameManagement.MainFuel);
                //Console.WriteLine("Probes: {0}", GameManagement.ProbeNumber);
                //Console.WriteLine(Environment.NewLine);
                Console.WriteLine("There are " + numberOfSystems + " star systems that are close enough for travel." + Environment.NewLine);

                Console.WriteLine("1. Star system");
                Console.WriteLine("This star system consists of " + planetsInFirstSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForFirstSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForFirstSystem) + Environment.NewLine);

                Console.WriteLine("2. Star system");
                Console.WriteLine("This star system consists of " + planetsInSecondSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForSecondSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForSecondSystem) + Environment.NewLine);

                Console.WriteLine("3. Star system");
                Console.WriteLine("This star system consists of " + planetsInThirdSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForThirdSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForThirdSystem) + Environment.NewLine);

                Console.WriteLine("4. Star system");
                Console.WriteLine("This star system consists of " + planetsInFirstSystem + " planets.");
                Console.WriteLine("Fuel required for travel: " + fuelCostForFourthSystem);
                Console.WriteLine("Fuel after travel: " + (GameManagement.MainFuel - fuelCostForFourthSystem) + Environment.NewLine);

            }
        }

        //Generation of planets
        public int generatePlanets()
        {
            Scan planets = new Scan();
            return planets.generatePlanets();
        }
        
        //Creates object for generating and retrieving fuel cost 
        public int fuelRequired()
        {
            Fuel newFuel = new Fuel();
            return newFuel.getFuelCost();
        }

        //Properties
        //Scan
        public static int NumberOfSystems
        {
            get
            {
                return numberOfSystems;
            }
            set
            {
                numberOfSystems = value;
            }
            
        }
        public static int PlanetsInFirstSystem
        {
            get
            {
                return planetsInFirstSystem;
            }
            set
            {
                planetsInFirstSystem = value;
            }
        }
        public static int PlanetsInSecondSystem
        {
            get
            {
                return planetsInSecondSystem;
            }
            set
            {
                planetsInSecondSystem = value;
            }
        }
        public static int PlanetsInThirdSystem
        {
            get
            {
                return planetsInThirdSystem;
            }
            set
            {
                planetsInThirdSystem = value;
            }
        }
        public static int PlanetsInFourthSystem
        {
            get
            {
                return planetsInFourthSystem;
            }
            set
            {
                planetsInFourthSystem = value;
            }
        }

        public static int FuelCostForFirstSystem
        {
            get
            {
                return fuelCostForFirstSystem;
            }
            set
            {
                fuelCostForFirstSystem = value;
            }
        }
        public static int FuelCostForSecondSystem
        {
            get
            {
                return fuelCostForSecondSystem;
            }
            set
            {
                fuelCostForSecondSystem = value;
            }
        }
        public static int FuelCostForThirdSystem
        {
            get
            {
                return fuelCostForThirdSystem;
            }
            set
            {
                fuelCostForThirdSystem = value;
            }
        }
        public static int FuelCostForFourthSystem
        {
            get
            {
                return fuelCostForFourthSystem;
            }
            set
            {
                fuelCostForFourthSystem = value;
            }
        }
    }
}
