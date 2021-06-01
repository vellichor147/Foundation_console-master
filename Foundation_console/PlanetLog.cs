using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class PlanetLog
    {
        public PlanetLog()
        {

        }

        public void PlanetLogScreenV2(int p_num)
        {
            // Planets loop
            for (int i = 1; i <= p_num; i++)
            {
                //Generate new planet
                PlanetProperties newPlanet = new PlanetProperties();
                newPlanet.generatePlanet();
                //Ship status
                ShipStatus.PrintStatus();
                //Planet log information
                Console.WriteLine("You have entered the orbit of " + i + ". planet." + Environment.NewLine);
                Console.WriteLine("Planet: {0}/{1}", i, p_num + Environment.NewLine);

                Console.WriteLine("INITIAL SCAN:");
                Console.WriteLine("Type: {0}", GameManagement.PlanetType);
                Console.WriteLine("Atmosphere: {0} ", GameManagement.AtmosphereType);
                Console.WriteLine("Average temperature: " + GameManagement.AverageTemeprature + " °C");
                Console.WriteLine("Additional info: {0}",GameManagement.AdditionalInfo);
                
                /*
                //Fuel extraction
                if (GameManagement.IsGasGiant == true)
                {
                    string atmo = getAtmo();
                    Console.WriteLine("Atmosphere: " + atmo);
                    Console.WriteLine("Average temperature: " + " °C");
                    //Water
                    if (GameManagement.HasAtmo == false)
                    {
                        Console.WriteLine("Water: none");
                    }
                    else if (GameManagement.HasAtmo == true)
                    {
                        Random r = new Random();
                        int w = r.Next(1, 3);
                        if (w == 1)
                        {
                            Console.WriteLine("Water: present");
                        }
                        else
                        {
                            Console.WriteLine("Water: ");
                        }

                    }

                }
                */
                 
                    Random r = new Random();
                    int rInt = r.Next(1, 11);
                    if (rInt <= 3)
                    {
                        if (GameManagement.HasRefuel == true)
                        {
                            Console.WriteLine("Fuel extraction: possible (press R to enter the atmosphere and refuel.) ");
                            GameManagement.RefuelQuery = true;
                        }
                        else
                        {
                            Console.WriteLine("Fuel extraction: possible (refueling technology required)");
                        }
                    }
                    else
                    {
                        if (GameManagement.HasRefuel == true)
                        {
                            Console.WriteLine("Fuel extraction: gasses in atmosphere not compatible for refueling.");
                        }
                        else
                        {
                            Console.WriteLine("Fuel extraction: gasses in atmosphere not compatible for refueling (refueling technology required)");
                        }
                    }
                    GameManagement.RefuelQuery = false;
                
                

                /*
                Console.WriteLine();
                if (GameManagement.RefuelQuery == true)
                {
                    Console.WriteLine("For refueling press R..." + Environment.NewLine);
                }
                if (GameManagement.ProbeNumber > 0 && GameManagement.ProbeSent == false)
                {
                    Console.WriteLine("Press P to send probe..." + Environment.NewLine);
                }
                if (GameManagement.Settle == false)
                {
                    Console.WriteLine("Press S to settle on planet..." + Environment.NewLine);
                }
                */
                

                Console.WriteLine("Press ENTER to travel to next planet.");

                GameManagement.nullPlanetInfo();

                bool enter = false;
                do
                {
                    ConsoleKeyInfo input;
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.R)
                    {
                        if (GameManagement.MainFuel < 1000)
                        {
                            Console.Clear();
                            refuelingAction();
                        }
                        else if (GameManagement.MainFuel == 1000)
                        {
                            Console.WriteLine("Fuel at maximum capacity.");
                        }
                    }
                    if (input.Key == ConsoleKey.P)
                    {
                        if (GameManagement.ProbeNumber > 0 && GameManagement.ProbeSent == false)
                        {
                            GameManagement.probeReduction(1);
                            GameManagement.ProbeSent = true;
                        }
                        else if (GameManagement.ProbeNumber > 0 && GameManagement.ProbeSent == true)
                        {
                            Console.WriteLine("Probe already sent!");
                        }
                        else if (GameManagement.ProbeNumber == 0)
                        {
                            Console.WriteLine("There are no available probes!");
                        }
                    }
                       
                    if (input.Key == ConsoleKey.Enter)
                    {
                        enter = true;
                    }

                } while (enter != true);


                Console.Clear();
            }

        }


        
        public void refuelingAction()
        {
            GameManagement.NumberOfEntry += 1;
            Console.WriteLine("Entering atmosphere...");
            Console.WriteLine("Commencing refueling process");
            if(GameManagement.HasHull == true && GameManagement.HasRefuel == true)
            {
                if (GameManagement.HullDamageLow == true)
                {
                    Console.WriteLine("Refueling succesful!");
                    int roomForFuel = 1000 - GameManagement.MainFuel;
                    Console.WriteLine("Fuel gathered: {0}", roomForFuel);
                    GameManagement.fuelIncrease(roomForFuel);
                }
                else if (GameManagement.HullDamageMid == true)
                {
                    Console.WriteLine("Refueling succesful!");
                    int roomForFuel = 1000 - GameManagement.MainFuel;
                    int topFuel = roomForFuel+1;
                    int lowFuel = roomForFuel / 4;
                    Random r = new Random();
                    int f = r.Next(lowFuel, topFuel);
                    Console.WriteLine("Fuel gathered: {0}", f);
                    GameManagement.fuelIncrease(roomForFuel);
                }
                else if (GameManagement.HullDamageHigh == true && GameManagement.NumberOfEntry == 5)
                {
                    Random a = new Random();
                    int aInt = a.Next(0,2);
                    if(aInt == 0)
                    {
                        Console.WriteLine("Refueling incoplete! High atmospheric pressure damaged ship's hull, repeating this procedure " +
                         "might result in complete destruction of ship. Hull integrity condition: critical ");
                        int roomForFuel = 1000 - GameManagement.MainFuel;
                        int topFuel = roomForFuel + 1;
                        int lowFuel = roomForFuel / 2;
                        Random r = new Random();
                        int f = r.Next(lowFuel, topFuel);
                        Console.WriteLine("Fuel gathered: {0}",f);
                        GameManagement.fuelIncrease(roomForFuel);
                    }
                    else
                    {
                        Console.WriteLine("Refueling failed! High atmospheric pressure damaged ship's hull, repeating this procedure " +
                        "might result in complete destruction of ship. Hull integrity condition: critical ");
                    }
                }
                else if (GameManagement.NumberOfEntry > 5)
                {
                    Random a = new Random();
                    int aInt = a.Next(0, 2);
                    if (aInt == 0)
                    {
                        Console.WriteLine("Refueling complete! Hull integrity condition: critical ");
                        int roomForFuel = 1000 - GameManagement.MainFuel;
                        int topFuel = roomForFuel + 1;
                        int lowFuel = Convert.ToInt32(roomForFuel / 1.2);
                        Random r = new Random();
                        int f = r.Next(lowFuel, topFuel);
                        Console.WriteLine("Fuel gathered: {0}", f);
                        GameManagement.fuelIncrease(roomForFuel);
                    }
                    else
                    {
                        Console.WriteLine("Ship is destoryed!");
                        Console.WriteLine("GAME OVER");
                    }
                }
                
            }
            if(GameManagement.HasHull == false && GameManagement.HasRefuel == true)
            {
                if (GameManagement.HullDamageLow == true)
                {
                    Console.WriteLine("Refueling succesful!");
                    int roomForFuel = 1000 - GameManagement.MainFuel;
                    Console.WriteLine("Fuel gathered: {0}", roomForFuel);
                    GameManagement.fuelIncrease(roomForFuel);
                }
                else if (GameManagement.HullDamageMid == true)
                {
                    Console.WriteLine("Refueling succesful!");
                    int roomForFuel = 1000 - GameManagement.MainFuel;
                    int topFuel = roomForFuel + 1;
                    int lowFuel = roomForFuel / 4;
                    Random r = new Random();
                    int f = r.Next(lowFuel, topFuel);
                    Console.WriteLine("Fuel gathered: {0}", f);
                    GameManagement.fuelIncrease(roomForFuel);
                }
                else if (GameManagement.HullDamageHigh == true && GameManagement.NumberOfEntry == 4)
                {
                    Random a = new Random();
                    int aInt = a.Next(0, 2);
                    if (aInt == 0)
                    {
                        Console.WriteLine("Refueling incoplete! High atmospheric pressure damaged ship's hull, repeating this procedure " +
                         "might result in complete destruction of ship. Hull integrity condition: critical ");
                        int roomForFuel = 1000 - GameManagement.MainFuel;
                        int topFuel = roomForFuel + 1;
                        int lowFuel = roomForFuel / 2;
                        Random r = new Random();
                        int f = r.Next(lowFuel, topFuel);
                        Console.WriteLine("Fuel gathered: {0}", f);
                        GameManagement.fuelIncrease(roomForFuel);
                    }
                    else
                    {
                        Console.WriteLine("Refueling failed! High atmospheric pressure damaged ship's hull, repeating this procedure " +
                        "might result in complete destruction of ship. Hull integrity condition: critical ");
                    }
                }
                else if (GameManagement.NumberOfEntry > 4)
                {
                    Random a = new Random();
                    int aInt = a.Next(0, 2);
                    if (aInt == 0)
                    {
                        Console.WriteLine("Refueling complete! Hull integrity condition: critical ");
                        int roomForFuel = 1000 - GameManagement.MainFuel;
                        int topFuel = roomForFuel + 1;
                        int lowFuel = Convert.ToInt32(roomForFuel / 1.2);
                        Random r = new Random();
                        int f = r.Next(lowFuel, topFuel);
                        Console.WriteLine("Fuel gathered: {0}", f);
                        GameManagement.fuelIncrease(roomForFuel);
                    }
                    else
                    {
                        Console.WriteLine("Ship is destoryed!");
                        Console.WriteLine("GAME OVER");
                    }
                }
            }
           
        }
        public string getPlanetType()
        {
            PlanetProperties newPlanet = new PlanetProperties();
            return newPlanet.generatePlanetType();
        }

        public string getAtmo()
        {
            Atmosphere newAtmo = new Atmosphere();
            return newAtmo.checkAtmo();
        }
        /*
        public int getTempType()
        {
            Temperature newTemp = new Temperature();
            string strTemp = newTemp.checkTemp();
            if (strTemp == "Hospitable")
            {
                return newTemp.HospitableTemp();
            }
            else
            {
                return newTemp.UnhospitableTemp();
            }
        }
        */
    }
}
