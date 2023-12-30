public static class BaseRaceStats {

    private static Dictionary<StatType, int> GetHumanBaseStats(bool isEnemy) {

        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 3 },
                { StatType.Perception, 3 },
                { StatType.Endurance, 3 },
                { StatType.Intelligence, 3 },
                { StatType.Agility, 3 },
                { StatType.Luck, 3 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 5 },
            { StatType.Perception, 5 },
            { StatType.Endurance, 5 },
            { StatType.Intelligence, 5 },
            { StatType.Agility, 5 },
            { StatType.Luck, 5 }
        };
    }

    private static Dictionary<StatType, int> GetElfBaseStats(bool isEnemy) {
        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 1 },
                { StatType.Perception, 4 },
                { StatType.Endurance, 2 },
                { StatType.Intelligence, 5 },
                { StatType.Agility, 4 },
                { StatType.Luck, 2 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 3 },
            { StatType.Perception, 6 },
            { StatType.Endurance, 4 },
            { StatType.Intelligence, 7 },
            { StatType.Agility, 6 },
            { StatType.Luck, 4 }
        };
    }

    private static Dictionary<StatType, int> GetDwarfBaseStats(bool isEnemy) {
        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 5 },
                { StatType.Perception, 1 },
                { StatType.Endurance, 5 },
                { StatType.Intelligence, 2 },
                { StatType.Agility, 1 },
                { StatType.Luck, 4 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 7 },
            { StatType.Perception, 3 },
            { StatType.Endurance, 7 },
            { StatType.Intelligence, 4 },
            { StatType.Agility, 3 },
            { StatType.Luck, 6 }
        };
    }

    private static Dictionary<StatType, int> GetLittleFolkBaseStats(bool isEnemy) {
        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 1 },
                { StatType.Perception, 4 },
                { StatType.Endurance, 1 },
                { StatType.Intelligence, 2 },
                { StatType.Agility, 5 },
                { StatType.Luck, 6 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 2 },
            { StatType.Perception, 6 },
            { StatType.Endurance, 3 },
            { StatType.Intelligence, 4 },
            { StatType.Agility, 7 },
            { StatType.Luck, 8 }
        };
    }

    private static Dictionary<StatType, int> GetOrcBaseStats(bool isEnemy) {
        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 6 },
                { StatType.Perception, 2 },
                { StatType.Endurance, 4 },
                { StatType.Intelligence, 1 },
                { StatType.Agility, 4 },
                { StatType.Luck, 2 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 8 },
            { StatType.Perception, 4 },
            { StatType.Endurance, 6 },
            { StatType.Intelligence, 2 },
            { StatType.Agility, 6 },
            { StatType.Luck, 4 }
        };
    }

    private static Dictionary<StatType, int> GetGoblinBaseStats(bool isEnemy) {
        if (isEnemy)
        {
            return new Dictionary<StatType, int>()
            {
                { StatType.Strength, 2 },
                { StatType.Perception, 5 },
                { StatType.Endurance, 2 },
                { StatType.Intelligence, 2 },
                { StatType.Agility, 5 },
                { StatType.Luck, 2 }
            };
        }

        return new Dictionary<StatType, int>() 
        {
            { StatType.Strength, 4 },
            { StatType.Perception, 7 },
            { StatType.Endurance, 4 },
            { StatType.Intelligence, 4 },
            { StatType.Agility, 7 },
            { StatType.Luck, 4 }
        };
    }

    public static Dictionary<StatType, int> GetBaseStats(string selectedRace, bool isEnemy) 
    {
        // TODO: Possible come up with better solution (what if race type enum values changes)
        switch (selectedRace)
        {
            case "Human":
                return GetHumanBaseStats(isEnemy);
            case "Elf":
                return GetElfBaseStats(isEnemy);
            case "Dwarf":
                return GetDwarfBaseStats(isEnemy);
            case "LittleFolk":
                return GetLittleFolkBaseStats(isEnemy);
            case "Orc":
                return GetOrcBaseStats(isEnemy);
            case "Goblin":
                return GetGoblinBaseStats(isEnemy);
            default:
                return null;
        }
            
    }
}