using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNetUdemy.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string AddressName { get; set; }
        public string Gender { get; set; }
    }
}
