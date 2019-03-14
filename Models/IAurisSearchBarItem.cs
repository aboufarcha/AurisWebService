using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AurisAPITest.Models
{
    public interface IAurisSearchBarItem
    {
        int ID { get; set; }
        string Category { get; set; }
        string Value { get; set; }

        int Order { get; set; }

        bool IsSelected { get; set; }
        bool IsVisible { get; set; }
        bool IsFirstItem { get; set; }

        bool IsActive { get; set; }
    }
}
