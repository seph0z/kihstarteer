using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Data.Contracts.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string UserId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
