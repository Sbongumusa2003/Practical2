using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Practical2.Models;

namespace Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {

            return View();
        }

        public static List<PersonModel> people = new List<PersonModel>()
        {
            new PersonModel{
                StuNumber = "u2565657",
                FirstName = "Nhlanhla",
                LastName = "Masina",
                Email = "u2565657@tuks.co.za",


            },
            new Models.PersonModel
            {
                StuNumber = "u57352688",
                FirstName = "Lindo",
                LastName = "Masumula",
                Email = "u57352688@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u24728997",
                FirstName = "Ayanda",
                LastName = "Mbatha",
                Email = "u24728997@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u22710362",
                FirstName = "Killer",
                LastName = "Kau",
                Email = "u22710362@tuks.co.za",

            },
            new Models.PersonModel
            {
                StuNumber = "u8396236",
                FirstName = "Lungile",
                LastName = "Mbatha",
                Email = "u8396236@tuks.co.za",

            }
        };





        public ActionResult Create()
        {
            return View();
        }
        public ActionResult ListPeople()
            {
            

                return View(people);

            }
        }

}