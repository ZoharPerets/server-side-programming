using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Users
    {
        public int UserID { get; set; }
        public string Status { get; set; }
        public string Level { get; set; }
        public string City { get; set; }
        public string BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public Users(string email, string password,string token)
        {
            Email = email;
            Password = password;
            Token = token;
        }

        public Users(int userId ,string email, string password, string firstName, string lastName, string status, string birthDate, string level, string city,string token)
        {
            UserID = userId;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Level = level;
            City = city;
            Token = token;
        }
        public Users( string email, string password, string firstName, string lastName, string status, string birthDate, string level, string city)
        {
            
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Level = level;
            City = city;
        }

        public Users(int id, string email, string password, string firstName, string lastName, string status, string birthDate, string level, string city)
        {
            UserID = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            BirthDate = birthDate;
            Level = level;
            City = city;
        }


        public Users(string email, string password, string firstName, string lastName)
        {

            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
          
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
