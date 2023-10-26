using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycafe.DataBaseData
{
    public class Items
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set;}
        public string Categoria { get; set; }
        public int Quantità { get; set; }
    }
}
