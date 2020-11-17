using Microsoft.AspNetCore.Mvc;
using dotnetcore_App.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character() { id = 1, name = "Sam" }
        };

        [HttpGet]
        public IActionResult getAll() {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult getCharacter(int id) {
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }
    }
}
