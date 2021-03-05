using System.Collections.Generic;

namespace exampleSQLite.Database
{
    public interface IReadAllData
    {
         public List<Post> GetAllPosts();
    }
}