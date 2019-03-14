using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AurisAPITest.Models
{
    public class PropertyItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Format { get; set; }
        public string Style { get; set; }
        public int Column { get; set; }
        public int Rang { get; set; }
        public StyleProperty PropertyStyle { get; set; }

        public bool IsVisible
        {
            get;
            set;
        } = true;
    }
}