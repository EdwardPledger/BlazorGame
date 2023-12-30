namespace BlazorApp1.Character
{
    public class CharacterBase
    {
        public string Name { get; set; } = "Nobody";
        public RaceType Race { get; set; } = RaceType.Human;
        public List<Equipment> Equipment { get; set; } = [];
        public List<Spell> Spells { get; set; } = [];
        public int Gold { get; set; } = 0;
        public Dictionary<StatType, int> Stats { get; set; } = [];
        public int HealthPoints { get; set; } = 0;
        public int MagicPoints { get; set; } = 0;
        public int Level { get; set; } = 1;

        public void CalculateBaseHealth() => HealthPoints = 10 + (Stats.GetValueOrDefault(StatType.Endurance) * 2) + (Level * 3);
        public void CalculateBaseMagic() => MagicPoints = 5 + (Stats.GetValueOrDefault(StatType.Intelligence) * 2) + (Level * 2);
       
    }
}
