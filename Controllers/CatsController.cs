using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using cats.Models;
using Microsoft.AspNetCore.Mvc;

namespace cats.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    public List<Cat> Cats = new List<Cat>()
    {
      new Cat("Mark", 2f),
      new Cat("Jake", 8.5f),
      new Cat("D$", 3f)
    };



    // GET api/Burgers
    [HttpGet]
    public IEnumerable<Cat> Get()
    {
      return Cats;
    }

    // GET api/Burgers/5
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      try
      {
        return Cats[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH Cat\"}");
      }
    }

    // POST api/Cats
    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat Cat)
    {
      Cats.Add(Cat);
      return Cats;
    }

    // PUT api/Cats/5
    [HttpPut("{id}")]
    public ActionResult<List<Cat>> Put(int id, [FromBody] Cat Cat)
    {
      try
      {
        Cats[id] = Cat;
        return Cats;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH Cat\"}");
      }
    }

    // DELETE api/Cats/5
    [HttpDelete("{id}")]
    public ActionResult<List<Cat>> Delete(int id)
    {
      try
      {
        Cats.Remove(Cats[id]);
        return Cats;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH Cat\"}");
      }
    }

  }
}
