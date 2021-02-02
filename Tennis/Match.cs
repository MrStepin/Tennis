using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Match
    {

        Player1 playerOne = new Player1();
        Player2 playerTwo = new Player2();
        Random randomNumber = new Random();

        public int Serve()
        {
            int serveScore = randomNumber.Next(0, 1);
            return serveScore;
        }

        public object Game()
        {
            int serve = 10;
            int scorePlayerOne = 0;
            int scorePlayerTwo = 0;

            while (
                  (scorePlayerTwo < (scorePlayerOne + 20)) |
                  (scorePlayerOne < (scorePlayerTwo + 20))
                   )
            {
                if (Serve() == 1)
                {
                    scorePlayerOne += playerTwo.WonServe(serve);
                }
                else
                {
                    scorePlayerTwo += playerOne.WonServe(serve);
                }
            }

            if (scorePlayerTwo < scorePlayerOne)
            {
                return playerOne;
            }
            else
            {
                return playerTwo;
            }
        }

        public object Set()
        {
            int game = 0;
            int wonGamesPlayerOne = 0;
            int wonGamesPlayerTwo = 0;

            while (((wonGamesPlayerTwo < (wonGamesPlayerOne + 2)) |
                   (wonGamesPlayerOne < (wonGamesPlayerTwo + 2))) &
                   ((wonGamesPlayerTwo != 6) & (wonGamesPlayerOne != 6)))
            {

                if (Game() == playerTwo)
                {
                    wonGamesPlayerTwo += playerTwo.WonSets(game);
                }
                else
                {
                    wonGamesPlayerOne += playerOne.WonSets(game);
                }

            }

            if ((wonGamesPlayerTwo == 6) & (wonGamesPlayerOne == 6))
            {
                game = 0;
                wonGamesPlayerOne = 0;
                wonGamesPlayerTwo = 0;

                while ((wonGamesPlayerTwo < (wonGamesPlayerOne + 2)) |
                       (wonGamesPlayerOne < (wonGamesPlayerTwo + 2)))
                {

                    if (Game() == playerTwo)
                    {
                        wonGamesPlayerTwo += playerTwo.WonSets(game);
                    }
                    else
                    {
                        wonGamesPlayerOne += playerOne.WonSets(game);
                    }

                }
            }
            if (wonGamesPlayerTwo < wonGamesPlayerOne)
            {
                return playerOne;
            }
            else
            { 
                return playerTwo;
            }

        }

        
    }
        
    
}
