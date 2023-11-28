using hajozas.Models;
using Microsoft.AspNetCore.Mvc;

namespace hajozas.Controllers
{
    public class BoatController : Controller
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult AllQuestion()
        {
            HajosContext context = new();
            var kerdesek = from x in context.Questions select x.Question1;

            return Ok(kerdesek);
        }

        [HttpGet]
        [Route("questions/{id}")]
        public IActionResult Question(int id)
        {
            HajosContext context = new();
            var kerdes = (from x in context.Questions
                         where x.QuestionId == id
                         select x).FirstOrDefault();
            
            if (kerdes == null) return BadRequest("Nincs ilyen sorszámú kérdés!");
            
            return new JsonResult(kerdes);
        }
    }
}
