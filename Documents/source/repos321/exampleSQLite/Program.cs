using System;
using System.Collections.Generic;
using System.Data.SQLite;
using exampleSQLite.Database;

namespace exampleSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption=GetMenuChoice();
        while (userOption!="4")
        {
            Route(userOption);
            userOption= GetMenuChoice();
        }

            
        }
        public static string GetMenuChoice()
        {
            DisplayMenu();
            string userOption = Console.ReadLine();

            while (!ValidMenuChoice(userOption))
            {
                Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();

                DisplayMenu();
                userOption = Console.ReadLine();
            }

            return userOption;
        }
   
        // set up menu
        public static void  DisplayMenu()
        {
            Console.WriteLine("Big Al Goes Social");
            Console.WriteLine("1) Show all Posts(ID,Post,Time Stamp)");
            Console.WriteLine("2) Add a post");
            Console.WriteLine("3) Delete a post by ID");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an Option: ");
            
        
        }

        public static bool ValidMenuChoice(string userOption)
        {
            /*Step 1 update ValidMenuChoice to return true if the user 
            entered 1, 2 or 3 and return false if they entered anything else.
            */
            if (userOption=="1")
            {
                return true;
            }              
            else if (userOption=="2")
            {
                return true;
            }
            else if (userOption=="3")
            {
                return true;
            }
            else if (userOption=="4")
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
         public static void Route( string userOption)
        {
             if (userOption=="1")
          {
              Console.WriteLine("Here are the current post: ");
              IReadAllData readObject = new ReadData();
            List<Post> allPosts = readObject.GetAllPosts();

            foreach (Post post in allPosts)
            {
                Console.WriteLine(post.ToString());
            }
            Console.ReadKey();
          } 
            else{
                if (userOption=="2")
                {
                                       
                    SaveData saveObject = new SaveData();
                    saveObject.SavePost();
                     IReadAllData readObject = new ReadData();
                    List<Post> allPosts = readObject.GetAllPosts();
                   
                    
                    foreach (Post post in allPosts)
                    {
                        Console.WriteLine(post.ToString());
                    }
                                          
                }
                 else{
                    if (userOption=="3") 
                    {
                        SaveData saveObject = new SaveData();
                        saveObject.DeletePost();
                        IReadAllData readObject = new ReadData();
                    List<Post> allPosts = readObject.GetAllPosts();
                         
                    
                        foreach (Post post in allPosts)
                        {
                            Console.WriteLine(post.ToString());
                        }
             
                    }
                    
                     else{
                        if (userOption=="4") 
                        {
                            Console.WriteLine("Exit");
                         }
                    }      
                 }
            }
        }
    }
}
