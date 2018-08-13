using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;

namespace ProjetoDaniel.Controllers
{
    [Produces("application/json")]
    [Route("api/Prato/")]
    [EnableCors("any")]
    public class PratoController : Controller
    {
        private readonly IPratoAppService _appService;
        public PratoController(IPratoAppService pratoAppService)
        {
            _appService = pratoAppService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get([FromBody]PratoDto pratoDto)
        {
            return Ok(_appService.GetPrato(pratoDto));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_appService.GetPratoById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]PratoDto pratoDto)
        {
            return Ok(_appService.SavePrato(pratoDto));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody]PratoDto pratoDto)
        {
            _appService.UpdatePrato(pratoDto);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appService.DeletePrato(id);
            return Ok();
        }
    }
}
