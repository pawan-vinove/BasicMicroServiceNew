using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
           DataContext db;
       public UserController()
        {
          db=new DataContext();  
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
         
            try
            {
          db.Users.Add(model);
            db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created,model);
            }
            catch (System.Exception)
            {
                
               return StatusCode(StatusCodes.Status500InternalServerError);
            } 
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
            var userdata=db.Users.Find(id);
               db.Users.Remove(userdata) ;
            db.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
