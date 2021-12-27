using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ZakazBar;

namespace ApiTattoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlkoControllers : Controller
    {
    [HttpGet]
        public List<ALKO> Get()
        {
            return DataAccess.GetALKO();
        }
        [HttpGet("{Id_alko}")]
        public ActionResult<ALKO> Get(int Id_alko)
        {
            var result = DataAccess.GetALKO(Id_alko);
            if (result == null)
                return NotFound();

            return result;
        }
        [HttpPost]
        public IActionResult Create(ALKO Id_alko)
        {
            DataAccess.AddNewALKO(Id_alko);
            return NoContent();
        }
    }
   
}
