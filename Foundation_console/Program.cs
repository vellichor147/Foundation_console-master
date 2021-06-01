using System;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Versioning;
using System.Threading;

namespace Foundation_console
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            //Introduction to the game
            Intro.Introduction();
            //Choosing technologies
            Technology.chooseTechnology();
            //Scanning effect
            GameManagement.scanMethod();
            
            //**********************************************************************
            //Repeat this code until settled or destroyed
            /*
            //ChoosingAndTravelling <-> ScanReport <-> SystemScan
            ChooseSystemClass newSystems = new ChooseSystemClass();
            newSystems.ChooseSystem();
            //Shows planet logs
            PlanetLog newLog = new PlanetLog();
            newLog.PlanetLogScreenV2(GameManagement.PlanetsInChosenSystem);
            */

            //test
            for(int i=0; i<5; i++)
            {
                //ChoosingAndTravelling <-> ScanReport <-> SystemScan
                ChooseSystemClass newSystems = new ChooseSystemClass();
                newSystems.ChooseSystem();
                //Shows planet logs
                PlanetLog newLog = new PlanetLog();
                newLog.PlanetLogScreenV2(GameManagement.PlanetsInChosenSystem);
                GameManagement.scanMethod();
            }
            
            

            //**********************************************************************



            //Console.ReadLine();

        }

    }
}
