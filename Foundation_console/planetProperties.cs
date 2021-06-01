using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class PlanetProperties
    {



        //properties

        //constructors
        //DEFAULT CONSTRUCTOR (only one)
        
        public PlanetProperties()
        {
            //CLASS INITIALIZATION CODE
        }
        

        //methods
        public string generatePlanetType()
        {
            Random r = new Random();
            int rInt = r.Next(1, 101);
            if (rInt <= 60)
            {
                GameManagement.IsPlanet = true;
                string pt = "Planet";
                return pt;
                //Console.WriteLine("You discovered a planet!");
            }
            else if (rInt > 60 && rInt <= 85)
            {
                GameManagement.IsGasGiant = true;
                string pt = "Gas giant";
                return pt;
                //Console.WriteLine("You discovered a gas giant!");
            }
            else //85-100
            {
                GameManagement.IsPlanetoid = true;
                string pt = "Planetoid";
                return pt;
                //Console.WriteLine("You discovered a planetoid!");
            }
            
        }

        public void generatePlanet()
        {
            Random r = new Random();
            int planetInt = r.Next(1, 101);
            //class D 0-10%, uninhabitable planetoid, moon, or small planet with little to no atmosphere
            if (planetInt > 0 && planetInt <= 10) //Class D
            {
                GameManagement.classD = true;
                Random r2 = new Random();
                int r2Int = r2.Next(1,3);
                // 1 - Moon, 2 - Planetoid
                if(r2Int == 1)
                {
                    GameManagement.PlanetType = "Moon";
                    GameManagement.AdditionalInfo = "Small and cratered moon.";
                }
                else
                {
                    GameManagement.PlanetType = "Planetoid";
                    GameManagement.AdditionalInfo = "Rock-based barren planetoid.";
                }
                //Atmosphere
                    GameManagement.AtmoD = true;
                    GameManagement.AtmosphereType = "Little to no atmosphere";
            }
            //Class H 10-20% - Generally uninhabitable for Humans.
            else if (planetInt > 10 && planetInt <= 20) 
            {
                GameManagement.classH = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "Does not support human life";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
                GameManagement.AdditionalInfo = " ";

            }
            //Class J - A type of gas giant.
            else if (planetInt > 20 && planetInt <= 30) 
            {
                GameManagement.classJ = true;
                GameManagement.IsGasGiant = true;
                GameManagement.PlanetType = "Gas giant";
                GameManagement.AtmosphereType = "Does not support human life";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }
            //Class K - Adaptable for Humans by use of artificial biospheres.
            else if (planetInt > 30 && planetInt <= 40)
            {
                GameManagement.classK = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "Does not support human life";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }
            //Class L -
            else if (planetInt > 30 && planetInt <= 40)
            {
                GameManagement.classL = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "Supports human life";
                GameManagement.AverageTemeprature = Temperature.HospitableTemp();
            }
            //Class M - Earth-like, with atmospheres containing oxygen and, typically, nucleogenic particles. 
            //          Largely habitable for humanoid life forms.
            else if (planetInt > 40 && planetInt <= 50)
            {
                GameManagement.classM = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "Supports human life";
                GameManagement.AverageTemeprature = Temperature.HospitableTemp();
            }
            //Class N -
            else if (planetInt > 50 && planetInt <= 60)
            {
                GameManagement.classN = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "//";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }
            //Class R -
            else if (planetInt > 60 && planetInt <= 70)
            {
                GameManagement.classR = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "//";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }
            //Class T - A type of gas giant.
            else if (planetInt > 70 && planetInt <= 80) 
            {
                GameManagement.classT = true;
                GameManagement.IsGasGiant = true;
                GameManagement.PlanetType = "Gas giant";
                GameManagement.AtmosphereType = "Does not support human life";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }
            //Class Y - A world with a toxic atmosphere and surface temperatures exceeding 500 Kelvin. 
            //          Prone to thermionic radiation discharges.
            else //Class Y
            {
                GameManagement.classY = true;
                GameManagement.IsPlanet = true;
                GameManagement.PlanetType = "Planet";
                GameManagement.AtmosphereType = "toxic";
                GameManagement.AverageTemeprature = Temperature.UnhospitableTemp();
            }






        }



    }
}
