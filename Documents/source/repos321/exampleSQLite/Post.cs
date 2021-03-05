using System;

namespace exampleSQLite
{
    public class Post
    {
        public int Id {get;set;}
        public string Tweet {get;set;}
        public DateTime Date{get;set;}

        public override string ToString()
        {
            return Id +" "+Tweet +" "+ Date;
        }

    }
}