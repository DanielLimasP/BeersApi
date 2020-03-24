using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BeersApi.Models;
using BeersApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeerService _beerService;

        public BeersController(BeerService beerService)
        {
            _beerService = beerService;
        }
        [HttpGet]
        public string hi()
        {
            return 
                "                Hello World From The API!!!\n" +
                "|-----------------------------------------------------------|\n" +
                "|                           Routes                          |\n" +
                "|-----------------------------------------------------------|\n" +
                "|/getall           [get]              Return all the beers  |\n" +
                "|-----------------------------------------------------------|\n" +
                "|/create           [post]                    Create a beer  |\n" +
                "|-----------------------------------------------------------|\n" +
                "|/getbeer{id}      [get]                     Return a beer  |\n" +
                "|-----------------------------------------------------------|\n" +
                "|/update{id}       [put]                     Update a beer  |\n" +
                "|-----------------------------------------------------------|\n" +
                "|/delete{id}       [delete]                  Delete a beer  |\n" +
                "|-----------------------------------------------------------|";
        }

        [HttpGet("getall", Name = "GetAll")]
        public ActionResult<List<Beers>> Get() =>
            _beerService.Get();

        [HttpGet("getbeer{id:length(24)}", Name = "GetBeer")]
        public ActionResult<Beers> Get(string id)
        {
            var beer = _beerService.Get(id);

            if (beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        [HttpPost("create")]
        public ActionResult<Beers> Create(Beers beer)
        {
            _beerService.Create(beer);
            return CreatedAtRoute("GetBeer", beer, null);
        }

        [HttpPut("update{id:length(24)}")]
        public IActionResult Update(string id, Beers beerIn)
        {
            var beer = _beerService.Get(id);

            if (beer == null)
            {
                return NotFound();
            }
            _beerService.Update(id, beerIn);

            return NoContent();
        }

        [HttpDelete("delete{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var beer = _beerService.Get(id);

            if (beer == null)
            {
                return NotFound();
            }

            _beerService.Remove(beer.Id);

            return NoContent();
        }
    }
}
