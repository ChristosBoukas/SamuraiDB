using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Models
{

    
    internal class Quote
    {
        public int Id { get; set; }
        public string SamuraiQuote { get; set; }
        public enQuoteType QuoteType { get; set; }
        public Samurai Samurai { get; set; }

        public Quote()
        {
            
        }


    }

    public enum enQuoteType { Lame, Cheesy, Awesome }

}
