using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Foundation_console
{
    public static class GameManagement
    {
        //Player name variable
        private static string playerName;

        //Ship status
        private static int mainFuel = 1000;
        private static int probeNumber = 15;
        private static bool hasAtmo;
        private static int numberOfEntry = 0;
        private static bool hullDamageLow = true;
        private static bool hullDamageMid = false;
        private static bool hullDamageHigh = false;

        //Technology
        private static int resources = 1000;
        private static bool hasRefuel = false;
        private static bool hasHull = false;
        private static bool hasProbes = false;
        private static bool hasStasis = false;
        private static bool hasMining = false;

        //Choice
        private static int planetsInChosenSystem;

        //Planet log
        private static bool refuelQuery = false;
        private static bool probeSent = false;
        private static bool settle = false;

        //Initial scan
        private static string planetType = "";
        private static string atmosphereType = "";
        private static int averageTemperature;
        private static string additionalInfo = "";

        private static bool isPlanet = false;
        private static bool isMoon = false;
        private static bool isPlanetoid = false;
        private static bool isGasGiant = false;
        private static bool atmoD = false;

        //Probe data
        private static bool hospitableTemperature = false;
        private static bool unhospitableTemperature = false;
        private static bool vegetation = false;

        //Planet classification
        //Class D - An uninhabitable planetoid, moon, or small planet with little to no atmosphere.
        //          Some were viable candidates for terraforming.
        //Class H - Generally uninhabitable for Humans.
        //Class J - A type of gas giant.
        //Class K - Adaptable for Humans by use of artificial biospheres.
        //Class L -
        //Class M - Earth-like, with atmospheres containing oxygen and, typically, nucleogenic particles. 
        //          Largely habitable for humanoid life forms.
        //Class N -
        //Class R -
        //Class T - A type of gas giant.
        //Class Y - A world with a toxic atmosphere and surface temperatures exceeding 500 Kelvin. 
        //          Prone to thermionic radiation discharges.
        public static bool classD = false;
        public static bool classH = false;
        public static bool classJ = false;
        public static bool classK = false;
        public static bool classL = false;
        public static bool classM = false;
        public static bool classN = false;
        public static bool classR = false;
        public static bool classT = false;
        public static bool classY = false;

        //Static constructor
        static GameManagement()
        {

        }

        //**********************************************
        //PROPERTIES
        public static string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        //Ship status properties
        public static int MainFuel
        {
            get { return mainFuel; }
            set { mainFuel = value; }
        }
        public static int ProbeNumber
        {
            get { return probeNumber; }
            set { probeNumber = value; }
        }
        public static bool HasAtmo
        {
            get { return hasAtmo; }
            set { hasAtmo = value; }
        }
        public static int NumberOfEntry
        {
            get { return numberOfEntry; }
            set { numberOfEntry = value; }
        }
        public static bool HullDamageLow
        {
            get { return hullDamageLow; }
            set { hullDamageLow = value; }
        }
        public static bool HullDamageMid
        {
            get { return hullDamageMid; }
            set { hullDamageMid = value; }
        }
        public static bool HullDamageHigh
        {
            get { return hullDamageHigh; }
            set { hullDamageHigh = value; }
        }

        //Technology properties
        public static int Resources
        {
            get { return resources; }
            set { resources = value; }
        }
        public static bool HasRefuel
        {
            get { return hasRefuel; }
            set { hasRefuel = value; }
        }
        public static bool HasHull
        {
            get { return hasHull; }
            set { hasHull = value; }
        }
        public static bool HasProbes
        {
            get { return hasProbes; }
            set { hasProbes = value; }
        }
        public static bool HasStasis
        {
            get { return hasStasis; }
            set { hasStasis = value; }
        }
        public static bool HasMining
        {
            get { return hasMining; }
            set { hasMining = value; }
        }

        //Choice
        public static int PlanetsInChosenSystem
        {
            get { return planetsInChosenSystem; }
            set { planetsInChosenSystem = value; }
        }

        //Planet log properties
        public static bool RefuelQuery
        {
            get { return refuelQuery; }
            set { refuelQuery = value; }
        }
        public static bool ProbeSent
        {
            get { return probeSent; }
            set { probeSent = value; }
        }
        public static bool Settle
        {
            get { return settle; }
            set { settle = value; }
        }

        //Initial scan properties
        public static string PlanetType
        {
            get { return planetType; }
            set { planetType = value; }
        }
        public static string AtmosphereType
        {
            get { return atmosphereType; }
            set { atmosphereType = value; }
        }
        public static string AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }
        public static int AverageTemeprature
        {
            get { return averageTemperature; }
            set { averageTemperature = value; }
        }

        public static bool IsPlanet
        {
            get { return isPlanet; }
            set { isPlanet = value; }
        }
        public static bool IsMoon
        {
            get { return isMoon; }
            set { isMoon = value; }
        }
        public static bool IsPlanetoid
        {
            get { return isPlanetoid; }
            set { isPlanetoid = value; }
        }
        public static bool IsGasGiant
        {
            get { return isGasGiant; }
            set { isGasGiant = value; }
        }
        public static bool AtmoD
        {
            get { return atmoD; }
            set { atmoD = value; }
        }

        //Probe data properties
        public static bool HospitableTemperature
        {
            get { return hospitableTemperature; }
            set { hospitableTemperature = value; }
        }
        public static bool UnhospitableTemperature
        {
            get { return hospitableTemperature; }
            set { hospitableTemperature = value; }
        }
        public static bool Vegetation
        {
            get { return hospitableTemperature; }
            set { hospitableTemperature = value; }
        }

        //Planet classification properties


        //**********************************************


        //Utility methods
        //**********************************************
        public static void PressEnter()
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
            }
            while (keyinfo.Key != ConsoleKey.Enter);
            Console.Clear();
        }

        public static void scanMethod()
        {
            Console.WriteLine("Press ENTER to scan for nearby star systems.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Scanning");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scanning...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scan complete!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void travelMethod()
        {
            Console.WriteLine("Travelling");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Travelling...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Scan complete!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void nullPlanetInfo()
        {

        planetType = "";
        atmosphereType = "";
        additionalInfo = "";

        isPlanet = false;
        isMoon = false;
        isGasGiant = false;
        atmoD = false;

        classD = false;
        classH = false;
        classJ = false;
        classK = false;
        classL = false;
        classM = false;
        classN = false;
        classR = false;
        classT = false;
        classY = false;
    }

        //*********************************************


        //Fuel methods
        //*********************************************
        public static void fuelReduction(int x)
        {
                mainFuel -= x;
        }

        public static void fuelIncrease(int x)
        {
            mainFuel += x;
        }

        public static void probeReduction(int x)
        {
            probeNumber -= x;
        }
        
        //*********************************************

    }
}
