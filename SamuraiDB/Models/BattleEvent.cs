using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Models
{
    internal class BattleEvent
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfEvent { get; set; }

    }
}
