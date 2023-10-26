using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycafe.DataBaseData
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string FullInfo 
        {
            get 
            {
                return $"{Username} ({Phone})";
            }
        }

    }
}
