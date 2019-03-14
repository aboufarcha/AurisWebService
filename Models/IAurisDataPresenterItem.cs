using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AurisAPITest.Models
{
    public interface IAurisDataPresenterItem
    {
        string Color { get; set; }
        string Image { get; set; }
        List<PropertyItem> Properties { get; set; }

    }
}
