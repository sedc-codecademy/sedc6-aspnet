using Sedc.WebApps.WebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sedc.WebApps.WebApiApp.Controllers
{
    public class PersonsController : ApiController
    {
        [HttpGet]
        public Person Info(string name, int age)
        {
            return new Person
            {
                Name = name,
                Age = age
            };
        }
    }
}
