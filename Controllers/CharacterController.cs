global using skyrim_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace skyrim_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")] //our webservice knows that this string id is the same value id of the paramater in the line below
        public ActionResult<List<Character>> GetSingle(int id) //find an chracter by their id
        {
            //return Ok(characters.FirstOrDefault(c => c.Id == id)); // returns the first character where the id of the character equals the given id
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            //characters.Add(newCharacter);
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}