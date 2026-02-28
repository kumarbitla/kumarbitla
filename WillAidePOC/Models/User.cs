using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WillAidePOC.Models
{
    public class User
    {
        public List<info> Users;

        public List<Nominee> UserNominee;
    }

    public class Nominee
    {
        public int userId { get; set; }
        public int usersNomineeId { get; set; }
        public List<info> nomineeNames { get; set; }

    }

    public class info{

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityOfResidence { get; set; }
        public string StateOfResidence { get; set; }
        public string PostalCode { get; set; }
        public Phone UserContact { get; set; }
        public Email UserEmail { get; set; }

    }

    public class Phone
    {
        public string PersonalNumber { get; set; }

        public string OfficeNumber { get; set; }
    }

    public class Email
    {
        public string PersonalEmail { get; set; }

        public string OfficeEmail { get; set; }
    }


}
