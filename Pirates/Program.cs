using System;

namespace Pirates
{
    class Pirate
    {
        private string name;
        private bool hasWoodenLeg;
        private bool hasParrot;

        public Pirate(string name, bool hasW, bool hasP)
        {
            this.name = name;
            this.hasWoodenLeg = hasW;
            this.hasParrot = hasP;
        }

        public Pirate(Pirate p)
        {
            this.name = p.name;
            this.hasParrot = p.hasParrot;
            this.hasWoodenLeg = p.hasWoodenLeg;
        }

        public bool GetHasWoodenLeg()
        {
            return this.hasWoodenLeg;
        }
    }

    class PirateShip
    {
        private Pirate captain;
        private Pirate[] pirates;
        private const int MAX_PIRATES = 100;
        private int numPirates;
        public PirateShip(Pirate captain)
        {
            this.captain = new Pirate(captain);
            this.pirates = new Pirate[MAX_PIRATES];
            this.numPirates = 0;
        }

        public void AddCrew(Pirate p)
        {
            if (this.numPirates < MAX_PIRATES)
            {
                this.pirates[this.numPirates] = new Pirate(p);
                this.numPirates++;
            }
        }
        public bool HasPirateWithWoodenLeg()
        {
            for (int i = 0; i < this.numPirates; i++)
            {
                if (this.pirates[i].GetHasWoodenLeg())
                    return true;
            }
            return false;
        }
    }
    class Program
    {
        static int CountShipdWithWoodenLegPirates(PirateShip [] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].HasPirateWithWoodenLeg())
                    counter++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
