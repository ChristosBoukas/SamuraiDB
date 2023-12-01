using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Models
{
    internal class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool wasBrutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Samurai> Samurais { get; set; } = new List<Samurai>();

        public Battle()
        {
            
        }
    }

    


}
