namespace CharacterManager.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public Genre Genre { get; set; }
        public int BonusDamge { get; set; }
        public int Charges { get; set; }
        public bool IsConsumable { get; set; }
        public decimal Price { get; set; }

    }
}