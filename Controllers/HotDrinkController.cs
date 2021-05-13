using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinksDispenser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DrinksDispenser.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HotDrinkController : ControllerBase
    {
        private readonly HotDrinkRepo _repo;
        private readonly IDrinksProcessor _processor;

        public HotDrinkController(HotDrinkRepo repo, IDrinksProcessor processor)
        {
            _repo = repo;
            _processor = processor;
        }

        [HttpGet]
        public IEnumerable<HotDrinkBase> Get()
        {
            return _repo.GetItems().ToArray();
        }

        [HttpGet("{id}")]
        public DrinksOrderResponse Get(int id)
        {
            return _processor.CreateDrinksOrder(id);
        }


    }


}