using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Games
    {
        public  int GameId {get;set;}
        public string Mode { get; set; }
        public  int Player1Score { get; set; }
        public  int Player2Score { get; set; }
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }

    }
}
