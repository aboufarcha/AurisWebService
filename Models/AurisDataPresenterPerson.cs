using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AurisAPITest.Models
{
    public class AurisDataPresenterPerson : IAurisDataPresenterItem
    {
        public string Color { get; set; }
        public string Image { get; set; }
        public List<PropertyItem> Properties { get; set; }

        private List<AurisDataPresenterCompte> _comptes;
        public List<AurisDataPresenterCompte> Comptes
        {
            get { return _comptes; }
            set
            {
                if (_comptes == value) return;
                _comptes = value;
            }
        }
    }
}