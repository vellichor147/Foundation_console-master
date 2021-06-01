using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Foundation_console
{
    static class Technology
    {
        //variables
        //private bool refueling;
        private static string inst = "(INSTALLED)";

        //TECHNOLOGY LIST
        //1. Refueling
        //This technology allows ship to collect fuel (on planets or nebulas) if it is available and process it for further use.
        //Pros: more fuel
        //Cons: entering planets atmosphere or nebulas might damage the ship
        //Resource cost: 400
        private static string fuel_str1 = "1. Refueling system ";
        private static string fuel_str2 = "This technology allows ship to collect fuel (on planets or nebulas) if it is available and process it for further use.";
        //private string fuel_str3 = "Pros: more fuel";
        //private string fuel_str4 = "Cons: entering planets atmosphere or nebulas might damage the ship";
        private static string fuel_str5 = "Resource cost: 500";
        private static int refuel_cost = 500;

        //2. Reinforced hull
        //Reinforced hull allows ship to take more damage. 
        //Resource cost: 400
        private static string hull_str1 = "2. Reinforced hull ";
        private static string hull_str2 = "Reinforced hull allows ship to take more damage.";
        private static string hull_str3 = "Resource cost: 300";
        private static int hull_cost = 300;

        //3. Additional probes
        //Increase number of probes from 15 to 25.
        private static string probes_str1 = "3. Additional probes ";
        private static string probes_str2 = "Increase number of probes from 15 to 25.";
        private static string probes_str3 = "Resource cost: 200";
        private static int probes_cost = 200;

        //4.Stasis drones
        //Stasis drones preform repairs to damaged stasis chambers.
        private static string stasis_str1 = "4. Stasis drones ";
        private static string stasis_str2 = "Stasis drones preform repairs to damaged stasis chambers.";
        private static string stasis_str3 = "Resource cost: 200";
        private static int stasis_cost = 200;

        //5.Mining equipment
        //Mining equipment for colonists to use afer colonizing planet.
        private static string mining_str1 = "5. Mining equipment ";
        private static string mining_str2 = "Mining equipment for colonists to use afer colonizing planet.";
        private static string mining_str3 = "Resource cost: 500";
        private static int mining_cost = 500;

        static Technology()
        {

        }


        /// <summary>
        /// technoBool method first checks condition of every technology bool and writes strings 
        /// of specific technology along with adding or removing '(INSTALLED)' depending on bool state
        /// </summary>
        public static void technoBool()
        {
            Console.WriteLine("Resources available: " + GameManagement.Resources);
            //Adding '(INSTALLED)'
            if (GameManagement.HasRefuel == true)
            {
                refuel(inst);
            }
            //Removing '(INSTALLED)'
            else
            {
                refuel();
            }
            if (GameManagement.HasHull == true)
            {
                hull(inst);
            }
            else
            {
                hull();
            }
            if (GameManagement.HasProbes == true)
            {
                probes(inst);
            }
            else
            {
                probes();
            }
            if (GameManagement.HasStasis == true)
            {
                stasis(inst);
            }
            else
            {
                stasis();
            }
            if (GameManagement.HasMining == true)
            {
                mining(inst);
            }
            else
            {
                mining();
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to confirm selected technologies and continue.");
        }
        
        /// <summary>
        /// chooseTechnology method allows user to choose certian technology, also once a certian 
        /// technology is selected it can be removed and vice versa until enter is pressed
        /// </summary>
        public static void chooseTechnology()
        {
            // bool enter - for checking if user pressed enter, if true method ends
            // technoBool() - checks state of technology bool and prints strings for all technolgies
            bool enter = false;
            technoBool();
            //Allows technology selection until enter is pressed
            do
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey();

                //If '1' is pressed refueling technology is selected
                if (input.Key == ConsoleKey.NumPad1)
                {
                    //If the bool is false, technology is not installed and
                    //'resources' variable will be reduced by technology cost
                    if (GameManagement.HasRefuel == false)
                    {
                        GameManagement.Resources -= refuel_cost;

                        //IF statement checks if value of 'resource' variable is now below zero
                        //if it is, it means there are actually no sufficient resources for choosing
                        //that technology and 'resources' variable will be returned to previous state
                        if (GameManagement.Resources < 0)
                        {
                            GameManagement.Resources += refuel_cost;
                            Console.Clear();
                            technoBool();
                            Console.WriteLine();
                            Console.WriteLine("Not enough resources for refueling system." + Environment.NewLine);
                        }
                        //if there are sufficient resources, 'resources' variable will remain reduced,
                        //console will be cleared and technoBool() will print technologies strings
                        //anew with added (INSTALLED) for Refueling technology
                        else
                        {
                            GameManagement.HasRefuel = true;
                            Console.Clear();
                            technoBool();
                        }
                        
                    }
                    //If the refueling bool is true, refueling will be removed
                    //bool will change to false, cost for technology will be returned to 
                    //'resources' variable and technologies will be printed anew
                    else
                    {
                        GameManagement.HasRefuel = false;
                        GameManagement.Resources += refuel_cost;
                        Console.Clear();
                        technoBool();
                    }
                }
                //If '2' is pressed hull technology is selected
                if (input.Key == ConsoleKey.NumPad2)
                {
                    if (GameManagement.HasHull == false)
                    {
                        GameManagement.Resources -= hull_cost;
                        if (GameManagement.Resources < 0)
                        {
                            GameManagement.Resources += hull_cost;
                            Console.Clear();
                            technoBool();
                            Console.WriteLine();
                            Console.WriteLine("Not enough resources for reinforced hull." + Environment.NewLine);
                        }
                        else
                        {
                            GameManagement.HasHull = true;
                            Console.Clear();
                            technoBool();
                        }
                    }
                    else
                    {
                        GameManagement.HasHull = false;
                        GameManagement.Resources += hull_cost;
                        Console.Clear();
                        technoBool();
                    }
                }
                //If '3' is pressed probes technology is selected
                if (input.Key == ConsoleKey.NumPad3)
                {
                    if (GameManagement.HasProbes == false)
                    {
                        GameManagement.Resources -= probes_cost;
                        if (GameManagement.Resources < 0)
                        {
                            GameManagement.Resources += probes_cost;
                            Console.Clear();
                            technoBool();
                            Console.WriteLine();
                            Console.WriteLine("Not enough resources for additional probes." + Environment.NewLine);  
                        }
                        else
                        {
                            GameManagement.HasProbes = true;
                            Console.Clear();
                            technoBool();
                        }
                    }
                    else
                    {
                        GameManagement.HasProbes = false;
                        GameManagement.Resources += probes_cost;
                        Console.Clear();
                        technoBool();
                    }
                }
                //If '4' is pressed stasis technology is selected
                if (input.Key == ConsoleKey.NumPad4)
                {
                    if (GameManagement.HasStasis == false)
                    {
                        GameManagement.Resources -= stasis_cost;
                        if (GameManagement.Resources < 0)
                        {
                            GameManagement.Resources += stasis_cost;
                            Console.Clear();
                            technoBool();
                            Console.WriteLine();
                            Console.WriteLine("Not enough resources for stasis drones." + Environment.NewLine);
                        }
                        else
                        {
                            GameManagement.HasStasis = true;
                            Console.Clear();
                            technoBool();
                        }
                    }
                    else
                    {
                        GameManagement.HasStasis = false;
                        GameManagement.Resources += stasis_cost;
                        Console.Clear();
                        technoBool();
                    }
                }
                //If '5' is pressed mining technology is selected
                if (input.Key == ConsoleKey.NumPad5)
                {
                    if (GameManagement.HasMining == false)
                    {
                        GameManagement.Resources -= mining_cost;
                        if (GameManagement.Resources < 0)
                        {
                            GameManagement.Resources += mining_cost;
                            Console.Clear();
                            technoBool();
                            Console.WriteLine();
                            Console.WriteLine("Not enough resources for mining equipment." + Environment.NewLine);
                        }
                        else
                        {
                            GameManagement.HasMining = true;
                            Console.Clear();
                            technoBool();
                        }
                    }
                    else
                    {
                        GameManagement.HasMining = false;
                        GameManagement.Resources += mining_cost;
                        Console.Clear();
                        technoBool();
                    }
                }
                //If enter is pressed technologies are selected and method ends
                if (input.Key == ConsoleKey.Enter)
                {
                    enter = true;
                }
            } while (enter != true);
            Console.Clear();
            Console.WriteLine("The ship is ready, you are now leaving Solar System in search of new home for human race...");
        }

        //Methods for writes technologies strings
        public static void refuel(string installed = " ")
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(fuel_str1 + installed);
            Console.WriteLine(fuel_str2);
            //Console.WriteLine(fuel_str3);
            //Console.WriteLine(fuel_str4);
            Console.WriteLine(fuel_str5);
        }

        public static void hull(string installed = " ")
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(hull_str1 + installed);
            Console.WriteLine(hull_str2);
            Console.WriteLine(hull_str3);
        }

        public static void probes(string installed = " ")
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(probes_str1 + installed);
            Console.WriteLine(probes_str2);
            Console.WriteLine(probes_str3);
        }

        public static void stasis(string installed = " ")
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(stasis_str1 + installed);
            Console.WriteLine(stasis_str2);
            Console.WriteLine(stasis_str3);
        }

        public static void mining(string installed = " ")
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(mining_str1 + installed);
            Console.WriteLine(mining_str2);
            Console.WriteLine(mining_str3);
        }
       
    }
}
