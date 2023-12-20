using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatApp.Model
{
   public class Person
    {
        public Person(string? personName, string? personLogin)
        {
            PersonName = personName;
            PersonLogin = personLogin;
        }

        public string? PersonName { get; set; }
        public string? PersonLogin { get; set; }
    }
}
