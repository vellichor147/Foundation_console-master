using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class ProbeData
    {
        public ProbeData()
        {

        }

        public void probeIntel()
        {
            if (GameManagement.classD == true)
            {
                //Temperature
                Random r = new Random();
                int temp = r.Next(1, 3);
                if (temp == 1)
                {
                    //Console.WriteLine("Average temperature: {0}", generateHospitableTemperature());
                    GameManagement.HospitableTemperature = true;
                }
                else
                {
                    //Console.WriteLine("Average temperature: {0}", generateUnhospitableTemperature());
                    GameManagement.UnhospitableTemperature = true;
                }
                //Vegetation
                GameManagement.Vegetation = false;
            }
            

            //Wildlife
        }

        public void checkVegetation()
        {
            if(GameManagement.classD == true)
            {
                GameManagement.Vegetation = false;
            }
        }

        /*
        public int generateHospitableTemperature()
        {
            Temperature newTemp = new Temperature();
            return newTemp.HospitableTemp();
        }

        public int generateUnhospitableTemperature()
        {
            Temperature newTemp = new Temperature();
            return newTemp.HospitableTemp();
        }
        */
    }
}
