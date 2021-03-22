using System.Collections.Generic;
using System.Data.SQLite;
using API.Models.Interfaces;

namespace API.Models
{
    public class ReadPostData : IGetAllPosts, IGetPost
    {
        public List<Post> GetAllPosts()
        {
            string cs = @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";

             using var con = new SQLiteConnection(cs);
            con.Open();

            string stm= "SELECT * FROM posts";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<Post> allPosts = new List<Post>();
            while (rdr.Read())
            {
                allPosts.Add(new Post(){Id=rdr.GetInt32(0), Tweet=rdr.GetString(1),Date=rdr.GetDateTime(2)});
            }

            return allPosts;
        }

        public Post GetPost(int id)
        {
            string cs = @"URI=file:C:\Users\keila\Documents\source\repos321\exampleSQLite\post.db";

             using var con = new SQLiteConnection(cs);
            con.Open();

            string stm= "SELECT * FROM posts WHERE id = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            return new Post(){Id=rdr.GetInt32(0), Tweet= rdr.GetString(1),Date=rdr.GetDateTime(2)};
        }
    }
}