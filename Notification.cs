using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Notification
    {
       public static string token;
       public static string bdy;
        public string to;
        public string title;
        public string body;



    
        public Notification( string to, string body)
        {
            
            this.to = "ExponentPushToken["+to+"]";
            title = "reminder!";
            this.body = body;
            token = to;

        }
        public  string GetTo()
        {
            return to;
        }
        public string GetBody()
        {
            return body;
        }



    }
}
