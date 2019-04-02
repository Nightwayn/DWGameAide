using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonWorldGameGuide.Models
{
    public class Character
    {
        public int CharID { get; set; }
        public int UserID { get; set; }
        public string CharacterName{ get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int AlignmentID { get; set; }
        public int InventoryID { get; set; }
    }
}
