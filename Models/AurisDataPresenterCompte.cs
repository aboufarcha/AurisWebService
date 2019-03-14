using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AurisAPITest.Models
{
    public class AurisDataPresenterCompte : IAurisDataPresenterItem
    {
        public string Color { get; set; }
        public string Image { get; set; }
        public List<PropertyItem> Properties { get; set; }
    }

}