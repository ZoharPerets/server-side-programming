using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Family
    {
        public int FamilyID { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Proximity { get; set; }
        public int UserId { get; set; }

        public Family(int id)
        {
            UserId = id;
        }


        public Family(int familyid, string firstName, string lastName, string status, string birthDate, string proximity, string city,int usreid)
        {
            FamilyID = familyid;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Proximity = proximity;
            City = city;
            UserId = usreid;
        }

        public Family( string firstName, string lastName, string status, string birthDate, string proximity, string city)
        {
           
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Proximity = proximity;
            City = city;
        }

        public Family(int userID, string firstName, string lastName, string status, string birthDate, string proximity, string city)
        {
            UserId = userID;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Proximity = proximity;
            City = city;
        }
    }
}
