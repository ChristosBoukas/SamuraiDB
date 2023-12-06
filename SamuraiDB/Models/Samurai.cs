using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Models
{
    internal class Samurai
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enHairstyle Hairstyle { get; set; }
        public ICollection<Battle> Battles { get; set; } = new List<Battle>();

        public SecretIdentity SecretIdentity { get; set; }

        public Samurai()
        {
            
        }


    }



    public enum enHairstyle { Chonmage, Oicho, Western }
}
