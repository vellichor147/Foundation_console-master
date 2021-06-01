using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    //Fuels calss contains method for generating fuel cost for travel to the system
    class Fuel
    {
        private int fuelCost;
        public Fuel()
        {

        }

        public int getFuelCost()
        {
            //60% chance for low fuel cost
            Random r = new Random();
            int probability = r.Next(1,11);
            if(probability <=6)
            {
                Random lCost = new Random();
                fuelCost = lCost.Next(100, 250);
                return fuelCost;
            }
            //40% chance for high fuel cost
            else
            {
                Random hCost = new Random();
                fuelCost= hCost.Next(250, 450);
                return fuelCost;
            }
            
        }


    }
}
