using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postsController : ControllerBase
    {
        // GET: api/posts
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Post> Get()
        {
            IGetAllPosts readObject = new ReadPostData();
            
            return readObject.GetAllPosts();
            
        }

        // GET: api/posts/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Post Get(int id)
        {
            IGetPost readObject = new ReadPostData();
            return readObject.GetPost(id);
        }

        // POST: api/posts
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Post value)
        {
            IInsertPost insertObject = new SavePost();
            insertObject.InsertPost(value);
        }

        // PUT: api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
