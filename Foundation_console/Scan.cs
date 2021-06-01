using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    //SystemScan class contains methods for generating number of discovered systems per scan and also number of planets per system
    class Scan
    {

        //CONSTRUCTOR
        public Scan()
        {

        }
        

        //METHODS
        //1.Closest system scan
        //Generate and return number of available systems after scan
        public static int generateSystems()
        {
            Random r = new Random();
            int rInt = r.Next(1, 101);
            if (rInt <= 40)
            {
                return 1;
            }
            else if (rInt > 40 && rInt <= 80)
            {
                return 2;
            }
            else if (rInt > 80 && rInt <= 95)
            {
                return 3;
            }
            else  //(rInt > 95 && rInt <= 100)
            {
                return 4;
            }
        }

        //2.Planets scan
        //Generate and return number of planets in system
        public int generatePlanets()
        {
            Random r = new Random();
            int rInt = r.Next(1, 101);
            if (rInt >= 1 && rInt <= 10)
            {
                return 5; 
            }
            else if (rInt > 10 && rInt <= 20)
            {
                return 6;
            }
            else if (rInt > 20 && rInt <= 30)
            {
                return 7;
            }
            else if (rInt > 40 && rInt <= 50)
            {
                return 8;
            }
            else if (rInt > 50 && rInt <= 60)
            {
                return 9;
            }
            else if (rInt > 60 && rInt <= 70)
            {
                return 10;
            }
            else if (rInt > 70 && rInt <= 80)
            {
                return 11;
            }
            else if (rInt > 80 && rInt <= 90)
            {
                return 12;
            }
            else // (rInt > 90 && rInt <= 100)
            {
                return 15;
            }

        }
        

    }
}
