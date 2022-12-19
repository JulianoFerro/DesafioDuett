using DesafioDuett.Models;
using DesafioDuett.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioDuett.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {

        private readonly IFruitService _fruitService;

        public FruitController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }

        // GET: api/<FruitController>
        [HttpGet]
        public async Task<ActionResult<List<Fruit>>> GetAllAsync()
        {
            var result = await _fruitService.GetAllAsync();
            return Ok(result);
        }

        // GET api/<FruitController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fruit>> GetByIdAsync(int id)
        {
            var result = await _fruitService.GetByIdAsync(id);
            return Ok(result);
        }

        // POST api/<FruitController>
        [HttpPost("multiply/{id}")]
        public async Task<ActionResult<Fruit>>MultiplyAsync(int id)
        {
            var result = await _fruitService.Multiply(id);
            return Ok(result);
        }

        // POST api/<FruitController>
        [HttpPost("divide/{id}")]
        public async Task<ActionResult<Fruit>> DivideAsync(int id)
        {
            var result = await _fruitService.DivideAsync(id);
            return Ok(result);
        }
    }
}
