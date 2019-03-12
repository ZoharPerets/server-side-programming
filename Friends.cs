using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Friends
    {
        public int FriendID { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }


        public Friends (int friendid, string firstName, string lastName, string status, string birthDate, string city,int userid)
        {
            FriendID = friendid;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            City = city;
            UserId= userid;
        }

        public Friends( string firstName, string lastName, string status, string birthDate, string city)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            City = city;
        }
    }
}
