using System.Collections.Generic;
using System.Data.SQLite;

namespace exampleSQLite.Database
{
    public class ReadData : IReadAllData
    {
        public List<Post> GetAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            string cs = @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";

             using var con = new SQLiteConnection(cs);
            con.Open();

            string stm= "SELECT * FROM posts";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                allPosts.Add(new Post(){Id=rdr.GetInt32(0), Tweet= rdr.GetString(1),Date=rdr.GetDateTime(2)});
            }

            return allPosts;
        }
    }
}