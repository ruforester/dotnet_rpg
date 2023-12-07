using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new()
        {
            new(),
            new() {Id=1, Name="Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(characters);
        }

        [HttpGet("{Id}")]
        public ActionResult<List<Character>> GetSingle(int Id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == Id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)

        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}