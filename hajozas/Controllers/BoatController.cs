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
    }
}
