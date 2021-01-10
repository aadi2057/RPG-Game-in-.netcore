using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "Sam", Id =2}
        };

        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}