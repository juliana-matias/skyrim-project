using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skyrim_project.Services.CharacterService //caminho das pastas e arquivos
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
    }

}