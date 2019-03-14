using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AurisAPITest.Models
{
    public class PersonImpl : IPerson
    {
        static int ID_Generator=1000;
        private string _iD;
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}