using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skyrim_project.Services.CharacterService //caminho das pastas e arquivos
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
        new Character(),
        new Character { Id =1 , Name = "MissKhajiit" }
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>(); // create a new service response object for every method and set the data property accordingly
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return  serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
           serviceResponse.Data = character;
            return serviceResponse;
        }
    }

}