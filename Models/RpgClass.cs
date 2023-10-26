using System.Text.Json.Serialization;

namespace skyrim_project.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Assassin = 1,
        Bandit = 2,
        Blade = 3,
        Conjurer = 4,
        Mage = 5,
        Nord = 6,
        Soldier = 7,
        Thief = 8,
        Vampire = 9,
        Warrior = 10,
        Khajiit = 11,
    }
}