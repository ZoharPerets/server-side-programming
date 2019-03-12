using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BEL;
using BAL;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using System.IO;
using System.Timers;
using System.Collections.Specialized;

namespace WakeUpMemory
{
    /// <summary>
    /// Summary description for WakeUpMemory
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WakeUpMemory : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string LoginUser(string token, string email, string password)
        {
            Users user = new Users(email, password, token);
            return new JavaScriptSerializer().Serialize(Operations.LoginUser(user));

        }
        [WebMethod]
        public string SignUp(string email, string password, string firstName, string lastName)
        {
            Users user = new Users(email, password, firstName, lastName);
           
                return new JavaScriptSerializer().Serialize(user);
        }
        [WebMethod]
        public string UpdateUser(string token,int userid, string email, string password, string firstName, string lastName, string status, string birthDate, string level, string city)
        {

            Users user = new Users(userid, email, password, firstName, lastName, status, birthDate, level, city);
           // DateTime datB= DateTime.Parse(birthDate).Date;
            
           //// Global.StartTimer(2,datB,token, "today is your birth date");
           // MyTimer timer = new MyTimer(token, "today is your birth date");
           // timer.SetInterval(datB);
           // timer.BindAction(OnTimedEvent);
           // timer.StartTimer();

            return new JavaScriptSerializer().Serialize(Operations.UpdateUser(user));

        }

        [WebMethod]
        public string InsertFamily(int userID, string firstName, string lastName, string status, string birthDate, string city, string proximity)
        {
            Family newFamily = new Family(userID, firstName, lastName, status, birthDate, proximity, city);
            return new JavaScriptSerializer().Serialize(Operations.InsertFamily(newFamily));
        }

        [WebMethod]
        public string GetFamily(int userID)
        {
            return new JavaScriptSerializer().Serialize(Operations.GetFamily(userID));
        }

        

        [WebMethod]
        public string InsertFriend(int userID, string firstName, string lastName, string status, string birthDate, string city)
        {
            Friends newFriend = new Friends(firstName, lastName, status, birthDate, city);
            return new JavaScriptSerializer().Serialize(Operations.InsertFriend(userID,newFriend));
        
        }

        [WebMethod]
        public string GetFriends(int userID)
        {
            return new JavaScriptSerializer().Serialize(Operations.GetFriends(userID));
        }
        [WebMethod]
        public string GetGames(int userID)
        {
            return new JavaScriptSerializer().Serialize(Operations.GetGames(userID));
        }
        public string InsertGame(int userID, string dateGame, int errors)
        {
            Games newGame = new Games(dateGame, errors);
            return new JavaScriptSerializer().Serialize(Operations.InsertGame(userID,newGame));
        }
        public string InsertActivity(int userID, string date, bool always, string time, string description)
        {
            Activities newActivity = new Activities(date, always, time, description);
            return new JavaScriptSerializer().Serialize(Operations.InsertActivity(userID,newActivity));
        }

        [WebMethod]
        public string GetActivities(int userID)
        {
            return new JavaScriptSerializer().Serialize(Operations.GetActivities(userID));
        }
        
        //[WebMethod]
        //public void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
             
            
        //    SendPushNotification();
        //}

        //[WebMethod]
        //public string SendPushNotification()
        //{

        //   // var values = new NameValueCollection();
        //   // values["to"] = token;
        //   // values["title]=titl
        //   // values["body"] = body;
        //   //string posData= new JavaScriptSerializer().Serialize(values);

        //    WebRequest request = WebRequest.Create("https://exp.host/--/api/v2/push/send");
        //  //  request.Method = "POST";
        //  //  Notification newNotification = new Notification( token, body);
        //   // string postData= new JavaScriptSerializer().Serialize(newNotification);
        //    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //    // Set the ContentLength property of the WebRequest.  
        //    request.ContentLength = byteArray.Length;
        //    // Get the request stream.  
        //    Stream dataStream = request.GetRequestStream();
        //    // Write the data to the request stream.  
        //    dataStream.Write(byteArray, 0, byteArray.Length);
        //    // Close the Stream object.  
        //    dataStream.Close();
        //    // Get the response.  
        //    WebResponse response = request.GetResponse();
        //    // Display the status.  
        //    string returnStatus = ((HttpWebResponse)response).StatusDescription;
        //    //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        //    // Get the stream containing content returned by the server.  
        //    dataStream = response.GetResponseStream();
        //    // Open the stream using a StreamReader for easy access.  
        //    StreamReader reader = new StreamReader(dataStream);
        //    // Read the content.  
        //    string responseFromServer = reader.ReadToEnd();
        //    // Display the content.  
        //    //Console.WriteLine(responseFromServer);
        //    // Clean up the streams.  
        //    reader.Close();
        //    dataStream.Close();
        //    response.Close();
        //    return "success"+ responseFromServer+","+returnStatus;
        //}

    }
}