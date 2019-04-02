using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonWorldGameGuide.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public int EmailID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
