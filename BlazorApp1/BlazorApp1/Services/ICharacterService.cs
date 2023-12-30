using BlazorApp1.Character;

namespace BlazorApp1.Services
{
    public interface ICharacterService
    {
        public PlayerCharacter GetCharacter(bool isPlayer);
    }
}
