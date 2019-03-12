using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BAL
{
    public class Operations
    {
        static public Users LoginUser(Users user)
        {
            return Dbconnection.LoginUser(user);
        }
        static public Users SignUp(Users user)
        {
            return Dbconnection.SignUp(user);
        }
        static public Users UpdateUser(Users user)
        {
            return Dbconnection.UpdateUser(user);
        }
        static public Users GetUser(string email)
        {
            return Dbconnection.GetUser(email);
        }
        static public Family InsertFamily(Family f)
        {
            return Dbconnection.InsertFamily(f);
        }
        static public List<Family> GetFamily(int userID)
        {
            return Dbconnection.GetFamily(userID);
        }
        static public Friends InsertFriend(int userId, Friends f)
        {
            return Dbconnection.InsertFriend(userId, f);
        }
        static public List<Friends> GetFriends(int userId)
        {
            return Dbconnection.GetFriends(userId);
        }
        static public Games InsertGame(int userId,Games newGame)
        {
            return Dbconnection.InsertGame(userId,newGame);
        }
        static public List< Games> GetGames(int userId)
        {
            return Dbconnection.GetGames(userId);
        }
        static public Activities InsertActivity(int userId, Activities newActivity)
        {
            return Dbconnection.InsertActivity(userId, newActivity);
        }
        static public List<Activities> GetActivities(int userId)
        {
            return Dbconnection.GetActivities(userId);
        }
    }
}
