using BlazorApp1.Character;

namespace BlazorApp1.Services
{
    public class CharacterService : ICharacterService
    {
        public PlayerCharacter GetCharacter(bool isPlayer)
        {
            // Temp
            return new PlayerCharacter
            {
                Name = "Nobody",
                Stats = BaseRaceStats.GetBaseStats("Human", false),
            };
        }
    }
}
