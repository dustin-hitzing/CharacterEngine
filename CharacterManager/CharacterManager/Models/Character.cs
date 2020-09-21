using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterManager.Models
{
    class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Might { get; set; }
        public int Agility { get; set; }
        public int Vigor { get; set; }
        public int Insight { get; set; }
        public int Spirit { get; set; }
        public List<Talent> Talents { get; set; }
        public int Level { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Skill> Skills { get; set; }
        public string Notes { get; set; }
        public List<Item> Items { get; set; }
        public int Damage { get; set; }
        public string DamageDisplay { get; set; }
        public int Health { get; set; }
        public int Grit { get; set; }
        public string Title { get; set; }
        public Campaign Campaign { get; set; }
    }
}
