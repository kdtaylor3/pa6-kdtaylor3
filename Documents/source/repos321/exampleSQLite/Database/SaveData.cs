using System;
using System.Data.SQLite;

namespace exampleSQLite.Database
{
    public class SaveData : ISeedData , ISaveData, IDeleteData
    {
        public void DeletePost()
        {
            string cs= @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";

            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            Console.WriteLine("Select the ID you would like to Delete");
            string ID = Console.ReadLine();
            cmd.CommandText = @"DELETE FROM posts WHERE id = '"+ID+"'";
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        public void SavePost()
        {
           string cs= @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";
             
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS posts";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE posts(id INTEGER PRIMARY KEY ,tweet TEXT,  date TEXT DEFAULT CURRENT_TIMESTAMP)";
            cmd.ExecuteNonQuery();

             cmd.CommandText =@"INSERT INTO posts(tweet) VALUES(@tweet)";

            cmd.Parameters.AddWithValue("@tweet","I hope this works");

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText =@"INSERT INTO posts(tweet) VALUES(@tweet)";

            cmd.Parameters.AddWithValue("@tweet","It workkkkksssss");

            cmd.Prepare();
            cmd.ExecuteNonQuery();

             using var conn = new SQLiteConnection(cs);
            conn.Open(); 

            using var cmd2 = new SQLiteCommand(conn);

            Console.WriteLine("Enter what you would like to say in new post");
            string Tweet = Console.ReadLine();
            cmd2.CommandText =@"INSERT INTO posts(tweet) VALUES('"+Tweet+"')";
            
            cmd2.Prepare();
            cmd2.ExecuteNonQuery();
        }

        public void SeedData()
        {
             string cs= @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";

            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS posts";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE posts(id INTEGER PRIMARY KEY ,tweet TEXT,  date TEXT DEFAULT CURRENT_TIMESTAMP)";
            cmd.ExecuteNonQuery();

             cmd.CommandText =@"INSERT INTO posts(tweet) VALUES(@tweet)";

            cmd.Parameters.AddWithValue("@tweet","I hope this works");

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText =@"INSERT INTO posts(tweet) VALUES(@tweet)";

            cmd.Parameters.AddWithValue("@tweet","It workkkkksssss");

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText =@"INSERT INTO posts(tweet) VALUES(@tweet)";

            cmd.Parameters.AddWithValue("@tweet","Im hungry");

            cmd.Prepare();
            cmd.ExecuteNonQuery();

             using var conn = new SQLiteConnection(cs);
            conn.Open(); 

            using var cmd2 = new SQLiteCommand(conn);

            Console.WriteLine("Enter what you would like to say in new post");
            string Tweet = Console.ReadLine();
            cmd2.CommandText =@"INSERT INTO posts(tweet) VALUES('"+Tweet+"')";
            
            cmd2.Prepare();
            cmd2.ExecuteNonQuery();
            

           
            
        }
    }
}