using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Abstracts
{
    public abstract class Person
    {
        [Browsable(false)]
        public int Id { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {

                string fullname = new CultureInfo("en-US").TextInfo.ToTitleCase(FirstName + " " + LastName);

                return fullname;

            }
        }
        [Browsable(false)]
        public string FirstName { get; set; }
        [Browsable(false)]
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }
        public string Email { get; set; }
      
    }
}
