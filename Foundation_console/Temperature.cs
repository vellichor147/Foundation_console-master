using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Foundation_console
{
    class Temperature : PlanetProperties
    {
        public Temperature()
        {

        }

        public string checkTemp()
        {
            Random rn = new Random();
            int t = rn.Next(1, 101);
            if (t >= 1 && t<= 80)
            {
                string temp = "Hospitable";
                return temp;
            }
            else
            {
                string temp = "Unhospitable";
                return temp;
            }
        }

        public static int UnhospitableTemp()
        {
            Random rt = new Random();
            int t = rt.Next(1, 101);
            if (t >= 1 && t <= 10)
            {
                Random r = new Random();
                int t1 = r.Next(-445, -226);
                return t1;
            }
            else if (t > 10 && t <= 45)
            {
                Random r = new Random();
                int t1 = r.Next(-225, -31);
                return t1;
            }
            else if (t > 45 && t <= 70)
            {
                Random r = new Random();
                int t1 = r.Next(61, 251);
                return t1;
            }
            else if (t > 70 && t <= 85)
            {
                Random r = new Random();
                int t1 = r.Next(251, 601);
                return t1;
            }
            else //85-100
            {
                Random r = new Random();
                int t1 = r.Next(601, 1500);
                return t1;
            }

        }

        public static int HospitableTemp()
        {
            Random r = new Random();
            int rt = r.Next(-30, 61);
            return rt;
        }

    }
}
