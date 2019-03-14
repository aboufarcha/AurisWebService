using AurisAPITest.Models;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AurisAPITest.Controllers
{
    public class PersonController : ApiController
    {
        static int ID_Generator = 1000;
        static List<IPerson> PersonList;
        public PersonController() {
            if(PersonList == null)
            {
                PersonList = Builder<PersonImpl>.CreateListOfSize(100)
                         .All()
                             .With(c => c.ID = "A" + ID_Generator++)
                             .With(c => c.FirstName = Faker.Name.First())
                             .With(c => c.LastName = Faker.Name.Last())
                         .Build().ToList<IPerson>();
            }
        }

        // GET: api/Person
        public IEnumerable<IPerson> Get()
        {
            return PersonList;
        }

        [Route("api/Person/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach (var p in PersonList) {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/Person/5
        public IPerson Get(string id)
        {
            return PersonList.Where(c=>c.FirstName==id).FirstOrDefault();
        }

        // POST: api/Person
        public void Post([FromBody]IPerson value)
        {
            PersonList.Add(value);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
