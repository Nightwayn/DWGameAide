using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonWorldGameGuide.Models
{
    public class Equipment
    {
        public int EquipID { get; set; }
        public string Name { get; set; }
        public bool IsStarterEquipment { get; set; }
        public string Category { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
    }
}
