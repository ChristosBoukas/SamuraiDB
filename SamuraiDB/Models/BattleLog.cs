using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Models
{
    internal class BattleLog
    {
        public int Id { get; set; }
        public Battle Battle { get; set; }
        public ICollection<BattleEvent> BattleEvents { get; set; }

    }
}
