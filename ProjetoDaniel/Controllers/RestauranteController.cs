using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Restaurante/")]
    [EnableCors("any")]
    public class RestauranteController : Controller
    {
        private readonly IRestauranteAppService _appService;
        public RestauranteController(IRestauranteAppService RestauranteAppService)
        {
            _appService = RestauranteAppService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get([FromBody]RestauranteDto RestauranteDto)
        {
            return Ok(_appService.GetRestaurante(RestauranteDto));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_appService.GetRestauranteById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]RestauranteDto RestauranteDto)
        {
            return Ok(_appService.SaveRestaurante(RestauranteDto));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody]RestauranteDto RestauranteDto)
        {
            _appService.UpdateRestaurante(RestauranteDto);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appService.DeleteRestaurante(id);
            return Ok();
        }
    }
}
