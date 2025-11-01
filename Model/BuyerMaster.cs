using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplication2.Model
{
    public class BuyerMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
