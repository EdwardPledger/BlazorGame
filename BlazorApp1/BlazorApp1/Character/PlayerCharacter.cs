namespace BlazorApp1.Character
{
    public class PlayerCharacter : CharacterBase
    {
        public int ExperiencePoints { get; set; } = 0;

        public bool CalculateLevelUp() => ExperiencePoints >= Level * 2 + 5;
        public void LevelUp()
        {
            CalculateBaseHealth();
            HealthPoints += (Level * 5);

            CalculateBaseMagic();
            MagicPoints += (Level * 3);
        }
    }
}
