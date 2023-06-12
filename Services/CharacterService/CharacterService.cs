using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doNetRPG.Services.CharacterService
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character>
    {
      new Character(),
      new Character{Id = 1, Name = "Sam"}
    };

    public List<Character> AddCharacter(Character newCharacter)
    {
      characters.Add(newCharacter);
      return characters;
    }

    public List<Character> GetAllCharacters()
    {
      return characters;
    }

    public Character GetCharacterById(int id)
    {
      var character = characters.FirstOrDefault(character => character.Id == id);
      if (character == null)
      {
        throw new Exception("Character not found");
      }
      return character;
    }
  }
}