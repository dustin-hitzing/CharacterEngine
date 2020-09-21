using System.Data;

namespace CharacterManager.Models
{
    public class Talent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public Genre Genre { get; set; }
        public StatType Type { get; set; }
    }
}