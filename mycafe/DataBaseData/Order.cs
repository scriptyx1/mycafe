using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycafe.DataBaseData
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<Items> Articoli { get; set; }
        public Users user { get; set; }
        
    }
}
