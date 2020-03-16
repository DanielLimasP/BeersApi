using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult<List<Beers>> Get() =>
            _beerService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBeer")]
        public ActionResult<Beers> Get(string id)
        {
            var beer = _beerService.Get(id);

            if (beer == null)
            {
                return NotFound();
            }

            return beer;
        }

        [HttpPost]
        public ActionResult<Beers> Create(Beers beer)
        {
            _beerService.Create(beer);
            return CreatedAtRoute("GetBeer", beer, null);
        }

        [HttpPut("{id:length(24)}")]
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

        [HttpDelete("{id:length(24)}")]
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
