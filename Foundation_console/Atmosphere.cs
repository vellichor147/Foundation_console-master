using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class Atmosphere : PlanetProperties
    {
        public Atmosphere()
        {

        }

        public string checkAtmo()
        {
            Random rn = new Random();
            int a = rn.Next(1, 101);
            if(a <= 75)
            {
                GameManagement.HasAtmo = true;
                return atmoType();
            }
            else 
            {
                string type = "None";
                GameManagement.HasAtmo = false;
                return type;  
            }
        }

        public string atmoType()
        {
            Random rn = new Random();
            int at = rn.Next(1, 101);
            if (at >= 1 && at <= 40)
            {
                string type = "Good";
                return type;
            }
            else if (at > 40 && at <= 70)
            {
                string type = "Thin, but supports human life";
                return type;
            }
            else
            {
                string type = "Toxic";
                return type;
            }

        }
    }
}
