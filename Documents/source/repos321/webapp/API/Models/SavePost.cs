using System;
using System.Data.SQLite;
using API.Models.Interfaces;

namespace API.Models
{
    public class SavePost : IInsertPost
    {
        public void InsertPost(Post value)
        {
            string cs= @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"INSERT INTO posts(tweet) VALUES(@tweet)";
            cmd.Parameters.AddWithValue("@tweet",value.Tweet);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }   
    }
}