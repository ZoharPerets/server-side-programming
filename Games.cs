using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Games
    {
        public int GameID { get; set; }
        public string DateGame { get; set; }
        public int countErrors { get; set; }
        public int UserId { get; set; }

        public Games(int gameid, string dateGame,int errors,int userid)
        {
            GameID = gameid;
            DateGame = dateGame;
            countErrors = errors;
            UserId = userid;
        }
        public Games( string dateGame, int errors)
        {
            DateGame = dateGame;
            countErrors = errors;
        }
    }
}
