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

        public int Game()
        {
            int _playerOneServe = playerOne.Serve();
            int _playerTwoServe = playerTwo.Serve();

            if (_playerOneServe == _playerTwoServe)
            {
               
            }

            playerOne.WonServes();
        }

    }
        
    
}
