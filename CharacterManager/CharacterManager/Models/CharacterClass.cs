using System.Collections.Generic;

namespace CharacterManager.Models
{
    public class CharacterClass
    {
        public string ClassName { get; set; }
        public List<Talent> ClassTalents { get; set; }
    }
}