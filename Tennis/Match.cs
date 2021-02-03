using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Match
    {

        Player playerOne = new Player();
        Player playerTwo = new Player();
        Random randomNumber = new Random();

        public int Serve()
        {
            int serveScore = randomNumber.Next(0, 2);
            return serveScore;
        }

        public object Game()
        {
            int serve = 15;
            int scorePlayerOne = 0;
            int scorePlayerTwo = 0;

            while (
                  ((scorePlayerTwo < (scorePlayerOne + 20)) && scorePlayerTwo<=40) &&
                  ((scorePlayerOne < (scorePlayerTwo + 20) && scorePlayerOne <= 40))
                   )
            {
                if (Serve() == 1)
                {
                    if (scorePlayerOne >= 30)
                    {
                        serve = 10;
                    }
                    scorePlayerOne += playerOne.WonServe(serve);
                }
                else
                {
                    if (scorePlayerTwo >= 30)
                    {
                        serve = 10;
                    }
                    scorePlayerTwo += playerTwo.WonServe(serve);
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

        public string Set()
        {
            int game = 0;
            int wonGamesPlayerOne = 0;
            int wonGamesPlayerTwo = 0;

            while (
                (((wonGamesPlayerTwo < (wonGamesPlayerOne + 2)) && wonGamesPlayerTwo<=6) &&
                   ((wonGamesPlayerOne < (wonGamesPlayerTwo + 2)) && wonGamesPlayerOne <= 6)) &&
                   ((wonGamesPlayerTwo != 6) && (wonGamesPlayerOne != 6))
                   )
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

            if ((wonGamesPlayerTwo == 6) && (wonGamesPlayerOne == 6))
            {
                game = 0;
                wonGamesPlayerOne = 0;
                wonGamesPlayerTwo = 0;

                while ((wonGamesPlayerTwo < (wonGamesPlayerOne + 2)) &&
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
                playerOne.Name = "First player";
                return playerOne.Name;
            }
            else
            {
                playerTwo.Name = "Second player";
                return playerTwo.Name;
            }

        }


        
    }
        
    
}
