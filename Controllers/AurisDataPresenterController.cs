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
    public class AurisDataPresenterController : ApiController
    {

        static List<AurisDataPresenterPerson> DataItems;

        public AurisDataPresenterController()
        {

             
        }
        // GET: api/AurisDataPresenter
        public List<AurisDataPresenterPerson> Get()
        {
            string[] Colors = new string[] { "green", "red", "yellow", "black", "white", "orange" };

            //Collection of images using to change add image to item
            string[] Paths = new string[] {
                  "/ASDK.Demo;component/Pictures/Accounts/AurisMaleIcon.png"
                , "/ASDK.Demo;component/Pictures/Accounts/AurisFemaleIcon.png"
                , "/ASDK.Demo;component/Pictures/Accounts/AurisGroupIcon.png" };

            //Generate List of second object

            var comptes = Builder<AurisDataPresenterCompte>.CreateListOfSize(10)
                .All()
                    .With(
                    c => c.Properties = new List<PropertyItem> {
                        new PropertyItem
                        {
                            Name = "Compte",
                            Value = Faker.Company.Name(),
                            Rang=1,
                            Column=2,
                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Gray"},
                        },new PropertyItem
                        {
                            Name = "Ville",
                            Value = Faker.Address.City(),
                            Rang=2,
                            Column=2,
                            IsVisible = false,
                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "", Foreground="Green"}
                        },
                         new PropertyItem
                        {
                            Name = "Pays",
                            Value=Faker.Address.Country(),
                            Rang=1,
                            Column=6,
                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Blue"}
                        }
                    })
                .Build();
            //Generate random data
            if (DataItems == null)
            {
                DataItems = Builder<AurisDataPresenterPerson>.CreateListOfSize(200)
                                .All()
                                    .With(
                                    c => c.Properties = new List<PropertyItem> {
                                        new PropertyItem
                                        {
                                            Name = "Nom",
                                            Value = Faker.Name.Last(),
                                            Rang=1,
                                            Column=2,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Gray"}
                                        },new PropertyItem
                                        {
                                            Name="Prenom",
                                            Value = Faker.Name.Last(),
                                            Rang=2,
                                            Column=2,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "", Foreground="Green"}
                                        },
                                         new PropertyItem
                                        {
                                            Name="Email",
                                            Value=Faker.Internet.Email(),
                                            Rang=1,
                                            Column=6,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Blue"}
                                        },
                                        new PropertyItem
                                         {
                                            Name="Ville",
                                            Value="Paris ",
                                            Rang=1,
                                            Column=4,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Red"}
                                        },
                                        new PropertyItem
                                         {
                                            Name="Pays",
                                            Value="France ",
                                            Rang=2,
                                            Column=4,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Red"}
                                        },
                                        new PropertyItem
                                         {
                                            Name="Adresse",
                                            Value=Faker.Address.SecondaryAddress(),
                                            Rang=3,
                                            Column=4,
                                            PropertyStyle =new StyleProperty {FontSize= 13,FontFamily= "Century Gothic", Foreground="Red"}
                                        }
                                    }).With(c => c.Comptes = new List<AurisDataPresenterCompte>(comptes)).
                                    With(c => c.Image = Paths[Faker.RandomNumber.Next(3)])
                                    .With(c => c.Color = Colors[Faker.RandomNumber.Next(6)])
                                    .Build().ToList();
            }
            return DataItems;
        }

        // GET: api/AurisDataPresenter/5
        public AurisDataPresenterPerson Get(int param)
        {
            return DataItems.Where(c => c.Properties.First().Value == param.ToString()).FirstOrDefault();
        }

        // POST: api/AurisDataPresenter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AurisDataPresenter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AurisDataPresenter/5
        public void Delete(int id)
        {
        }
    }
}
