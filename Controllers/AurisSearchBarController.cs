using AurisAPITest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AurisAPITest.Controllers
{
    public class AurisSearchBarController : ApiController
    {
        public List<string> SourceItemsCategories = new List<string>();
        public AurisSearchBarController()
        {
          
            SourceItemsCategories = (new string[] { "Nom", "Prenom", "Mail", "Ville", "Pays" }).ToList<string>();
            
        }
        // GET: api/AurisSearchBar
        public IEnumerable<string> Get()
        {
            return SourceItemsCategories;
        }

        // GET: api/AurisSearchBar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AurisSearchBar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AurisSearchBar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AurisSearchBar/5
        public void Delete(int id)
        {
        }
    }
}
