using hands_on_lab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hands_on_lab.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult osszesKerdes()
        {
            HajosContext context = new HajosContext();
            var kerdesek = from x in context.Questions select x.Question1;

            return Ok(kerdesek);
        }

        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult kerdesSorszam(int sorszám)
        {
            HajosContext context = new HajosContext();
            var kérdés = (from x in context.Questions
                          where x.QuestionId == sorszám
                          select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return new JsonResult(kérdés);
        }
    }
}
