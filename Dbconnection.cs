using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Dbconnection
    {

        static private SqlConnection con = new SqlConnection(@"Data Source=185.60.170.14;Integrated Security=False;User ID=SITE15;Password=vcD#f917;");

        static public Users LoginUser(Users user)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginUser";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@email", user.Email));
                cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                cmd.Parameters.Add(new SqlParameter("@token", user.Token));

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Users(int.Parse(reader["userID"].ToString()), reader["email"].ToString(), reader["pasword"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["level"].ToString(), reader["city"].ToString(), reader["token"].ToString());
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public Users SignUp(Users user)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertUser";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userFirstName", user.FirstName));
                cmd.Parameters.Add(new SqlParameter("@userLastName", user.LastName));
                cmd.Parameters.Add(new SqlParameter("@userEmail", user.Email));
                cmd.Parameters.Add(new SqlParameter("@userPassword", user.Password));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Users(int.Parse(reader["userID"].ToString()), reader["email"].ToString(), reader["pasword"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["level"].ToString(), reader["city"].ToString(), reader["token"].ToString());
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public Users UpdateUser(Users user)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdatetUser";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userID", user.UserID));
                cmd.Parameters.Add(new SqlParameter("@userFirstName", user.FirstName));
                cmd.Parameters.Add(new SqlParameter("@userLastName", user.LastName));
                cmd.Parameters.Add(new SqlParameter("@userEmail", user.Email));
                cmd.Parameters.Add(new SqlParameter("@userPassword", user.Password));
                cmd.Parameters.Add(new SqlParameter("@userStatus", user.Status));
                cmd.Parameters.Add(new SqlParameter("@userCity", user.City));
                cmd.Parameters.Add(new SqlParameter("@userLevel", user.Level));
                cmd.Parameters.Add(new SqlParameter("@userBirthDate", user.BirthDate));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Users(int.Parse(reader["userID"].ToString()), reader["email"].ToString(), reader["pasword"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["level"].ToString(), reader["city"].ToString(), reader["token"].ToString());
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public Users GetUser(string email)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUser";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@email", email));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Users(int.Parse(reader["userID"].ToString()), reader["email"].ToString(), reader["pasword"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["level"].ToString(), reader["city"].ToString(), reader["token"].ToString());
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public Family InsertFamily(Family family)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertFamily";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", family.UserId));
                cmd.Parameters.Add(new SqlParameter("@FamilyFirstName", family.FirstName));
                cmd.Parameters.Add(new SqlParameter("@FamilyLastName", family.LastName));
                cmd.Parameters.Add(new SqlParameter("@FamilyProximity", family.Proximity));
                cmd.Parameters.Add(new SqlParameter("@FamilyStatus", family.Status));
                cmd.Parameters.Add(new SqlParameter("@FamilyCity", family.City));
                cmd.Parameters.Add(new SqlParameter("@FamilyBirthDate", family.BirthDate));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Family(int.Parse(reader["familyID"].ToString()), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["proximity"].ToString(), reader["city"].ToString(), int.Parse(reader["userID"].ToString()));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();

                    con.Close();
                }
            }
            return null;
        }

        static public List<Family> GetFamily(int userID)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetFamily";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId",userID));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                List<Family> familyList = new List<Family>();

                while (reader.Read())
                {
                    Family newFamily = new Family(int.Parse(reader["familyID"].ToString()), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["proximity"].ToString(), reader["city"].ToString(), int.Parse(reader["userID"].ToString()));
                    familyList.Add(newFamily);
                }

                return familyList;

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }
        static public Friends InsertFriend(int userId, Friends friend)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InserFriend";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@friendFirstName", friend.FirstName));
                cmd.Parameters.Add(new SqlParameter("@friendLastName", friend.LastName));
                cmd.Parameters.Add(new SqlParameter("@friendStatus", friend.Status));
                cmd.Parameters.Add(new SqlParameter("@friendyCity", friend.City));
                cmd.Parameters.Add(new SqlParameter("@friendBirthDate", friend.BirthDate));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Friends(int.Parse(reader["friendsID"].ToString()), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["city"].ToString(), int.Parse(reader["userID"].ToString()));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public List<Friends> GetFriends(int userId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetFriends";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                List<Friends> friendsList = new List<Friends>();


                if (reader.Read())
                {
                    Friends newFriend= new Friends (int.Parse(reader["friendsID"].ToString()), reader["firstName"].ToString(), reader["lastName"].ToString(), reader["status"].ToString(), reader["birthDate"].ToString(), reader["city"].ToString(),int.Parse(reader["userID"].ToString()));
                    friendsList.Add(newFriend);

                }
                return friendsList;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }
        static public Games InsertGame(int userId, Games newGame)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InserGame";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@dateGame", newGame.DateGame ));
                cmd.Parameters.Add(new SqlParameter("@countErrors", newGame.countErrors));
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Games(int.Parse(reader["gameID"].ToString()), reader["dateGame"].ToString(), int.Parse(reader["countErrors"].ToString()), int.Parse(reader["userID"].ToString()));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {

                    con.Close();
                }
            }
            return null;
        }

        static public List<Games> GetGames(int userId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetFriends";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();
                List<Games> GamesList = new List<Games>();

                if (reader.Read())
                {
                    Games newGame= new Games (int.Parse(reader["gameID"].ToString()), reader["dateGame"].ToString(), int.Parse(reader["countErrors"].ToString()), int.Parse(reader["userID"].ToString()));
                    GamesList.Add(newGame);
                    
                }
                return GamesList;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }
        static public Activities InsertActivity(int userId, Activities newActivity)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertActivity";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@date", newActivity.Date));
                cmd.Parameters.Add(new SqlParameter("@time", newActivity.Time));
                cmd.Parameters.Add(new SqlParameter("@description", newActivity.Description));
                cmd.Parameters.Add(new SqlParameter("@always", newActivity.Always));

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                     return new Activities(int.Parse(reader["activityID"].ToString()), reader["date"].ToString(), Convert.ToBoolean(reader["always"].ToString()), reader["time"].ToString(), reader["description"].ToString(), int.Parse(reader["userID"].ToString()));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }

        static public List<Activities> GetActivities(int userId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetActivities";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();
                List<Activities> activitiesList = new List<Activities>();


                if (reader.Read())
                {
                    Activities newActivity= new Activities (int.Parse(reader["activityID"].ToString()), reader["date"].ToString(),Convert.ToBoolean(reader["always"].ToString()), reader["time"].ToString(),reader["description"].ToString(),int.Parse(reader["userID"].ToString()));
                    activitiesList.Add(newActivity);
                }
                return activitiesList;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    reader.Close();
                    con.Close();
                }
            }
            return null;
        }
    }


}
