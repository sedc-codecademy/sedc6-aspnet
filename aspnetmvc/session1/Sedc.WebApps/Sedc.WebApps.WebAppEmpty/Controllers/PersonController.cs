using Sedc.WebApps.WebAppEmpty.Models;
using System.Web.Mvc;

namespace Sedc.WebApps.WebAppEmpty.Controllers
{
    public class PersonController : Controller
    {
        public string Info(Person person)
        {            
            return $"my name is {person.Name}, and age: {person.Age}";
        }
    }
}