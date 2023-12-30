namespace BlazorApp1.Character
{
    public class HumanCharacter : CharacterCreator
    {
        public override EnemyCharacter CreateCharacter(int level)
        {
            var humanCharacter = new EnemyCharacter
            {
                Name = $"Level {level} Human",
                Race = RaceType.Human,
                Stats = BaseRaceStats.GetBaseStats(Enum.Parse(typeof(RaceType), "Human").ToString(), true)
            };
            humanCharacter.CalculateBaseHealth();
            humanCharacter.CalculateBaseMagic();
            humanCharacter.ExperiencePoints = 7;

            return humanCharacter;
        }
    }
}
