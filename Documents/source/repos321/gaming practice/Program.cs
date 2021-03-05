using System;

namespace gaming_practice
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nWelcome to the Battle of the Ages " + name + "!");
            
         // computer choose random
         string[] choices = new string[3]{"Aang", "Katara", "Zuko"};
          Random r = new Random();
          int computerCharacter = r.Next(0,3);
   
         Console.WriteLine(name+" VS "+choices[computerCharacter] +"!\nLet the battle begin!!!");
            
           Character player1 = new Character(name,100);
           Character player2 = new Character(choices[computerCharacter], 100);
           GameUtil.StartFight(player1,player2);
           Console.ReadLine();
        }
    }
}
