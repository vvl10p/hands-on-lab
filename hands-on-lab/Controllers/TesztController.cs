using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hands_on_lab.Controllers
{
    //Commentbe vele!
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : Controller
    {
        [HttpGet]
        [Route("corvinus/pontosido")]
        public IActionResult pontosIdo()
        {
            string pontosido = DateTime.Now.ToShortTimeString();

            return Ok(pontosido);
        }

        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]

        public IActionResult nagyBetus(string szoveg)
        {
            return Ok(szoveg.ToUpper());
        }
    }
}
