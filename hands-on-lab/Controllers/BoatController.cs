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
    }
}
