using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class ShipStatus
    {

        public static void PrintStatus()
        {
            Console.WriteLine("Fuel: " + GameManagement.MainFuel);
            Console.WriteLine("Probes: {0}", GameManagement.ProbeNumber);
            // Hull status
            // If upgraded hull technology is implemented
            // 0-2 entries = no damage
            // 2-4 entries = slightly damaged
            // > 4 = severe damage (high risk of complete hull failure)
            if (GameManagement.HasHull == true)
            {
                if (GameManagement.NumberOfEntry >= 0 && GameManagement.NumberOfEntry <= 2)
                {
                    string hullIntegrity = "no damage";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageLow = true;
                }
                else if (GameManagement.NumberOfEntry > 2 && GameManagement.NumberOfEntry <= 4)
                {
                    string hullIntegrity = "slightly damaged";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageLow = false;
                    GameManagement.HullDamageMid = true;

                }
                else
                {
                    string hullIntegrity = "severe damage (high risk of complete hull failure)";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageMid = false;
                    GameManagement.HullDamageHigh = true;
                }
            }
            // No upgraded hull
            // 0-1 = no damage
            // slightly damaged
            // severe damage
            else //hasHull = false;
            {
                if (GameManagement.NumberOfEntry >= 0 && GameManagement.NumberOfEntry <= 1)
                {
                    string hullIntegrity = "no damage";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageLow = true;
                }
                else if (GameManagement.NumberOfEntry > 1 && GameManagement.NumberOfEntry <= 3)
                {
                    string hullIntegrity = "slightly damaged";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageLow = false;
                    GameManagement.HullDamageMid = true;

                }
                else
                {
                    string hullIntegrity = "severe damage (high risk of complete hull failure)";
                    Console.WriteLine("Hull integrity condition: {0}", hullIntegrity);
                    GameManagement.HullDamageMid = false;
                    GameManagement.HullDamageHigh = true;
                }
            }

            Console.Write("________________________________________");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
