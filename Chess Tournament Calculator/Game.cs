using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Tournament_Calculator
{
    public  class Game
    {
        public string Player_White { get; set; }
        public string Player_Black { get; set; }
        public string? PGN { get; set; }
        public double Result { get; set; }
        public string Draw_Reason { get; set; }
        // 3fold repetition, 50-move rule,agreement, stalemate
        public string Decisive_Reason { get; set; }
        // timeout, checkmate, resignation, decided by jusge

    }
}
