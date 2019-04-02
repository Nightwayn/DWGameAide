using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonWorldGameGuide.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int CharID { get; set; }
        public int EquipID { get; set; }
        public int Load { get; set; }
    }
}
