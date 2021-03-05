using System;

namespace gaming_practice
{
    public class GameUtil
    {
        public static void StartFight(Character player1,Character player2)
        {
            while (true)
            {
                if (GetAttackStat(player1,player2)== "Game Over")
                {
                    Console.WriteLine(" Game Over");
                    break;
                }
                if (GetAttackStat(player2,player1)== "Game Over")
                {
                    Console.WriteLine(" Game Over");
                    break;
                }
            }
            
        }
        // get attack results
            public static string GetAttackStat(Character playerA,Character playerB)
            {
               // calculate 1 players attack and others block
            double  plrAAttkAmt = playerA.Attack();
            double  plrBBlkAmt = playerB.Defense();

            //subtract block from attack
            double  damage2PlyB= (plrAAttkAmt-plrBBlkAmt)*(1.2);

            // if damage subtract from health
            if (damage2PlyB > 0)
            {
               playerB.Health = playerB.Health - damage2PlyB; 
            }
            else
            {
                damage2PlyB = 0;
            }
            // display who attacked who and amount of damage
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", playerA.Name,playerB.Name, damage2PlyB);

            //display stat of health
            Console.WriteLine("{0} Has {1} Health\n", playerB.Name,playerB.Health);
             Console.WriteLine("{0} Has {1} Health\n", playerA.Name,playerA.Health);

            //check to see if player health is below 0 if so end the loop
            if (playerB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} has won the game\n", playerB.Name, playerA.Name);
                return "Game Over";
            }
            else return "Fight Again";
         
            }




























    //   public static void PickCharacter()
    //   {
    //       Console.WriteLine("Please enter your name: ");
    //         string name = Console.ReadLine();
    //         Console.WriteLine("\nWelcome to the Battle of the Ages " + name + "!");
            
    //      // computer choose random
    //       Random r = new Random();
    //       int computerCharacter = r.Next(3);

    //         if (computerCharacter==1)
    //         {
    //              Console.WriteLine(name+" VS Aang!\nLet the battle begin!!!");
    //         }
    //         else if (computerCharacter==2)
    //         {
    //           Console.WriteLine(name+" VS Katara!\n Let the battle begin!!!");  
    //         }
    //         else if (computerCharacter==3)
    //         {
    //            Console.WriteLine(name+" VS Zuko!\n Let the battle begin!!!");
    //         }
                    
         
    //   } 

    }
}