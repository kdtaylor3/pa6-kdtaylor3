using System;

namespace gaming_practice
{
    public class Character
    {
        public string Name {get;set;}
        public double Health {get;set;}
        public double MaxP {get;set;}
        public double AttkP {get;set;}
        public double DefsP {get;set;}

        //create random instance
        Random r = new Random();

        // constructor initializing the character
        public Character(string name="", double health=0,double maxp = 0, double attkp =0, double defsp = 0)
        {
            Name = name;
            Health = health;
            MaxP = maxp;
            AttkP = attkp;
            DefsP = defsp;
        }

        //generate random max power int from 1 to 100 
        public int MaxPower()
        {
            return r.Next(1,101);
        }

        // generate random attack int between 1 and max power
        public double Attack()
        {
            return r .Next(1, MaxPower());
        }

        // generate random attack int between 1 and max power
        public double Defense()
        {
            return r .Next(1,MaxPower());
        }
    }
    
}