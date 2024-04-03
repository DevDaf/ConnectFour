using Xunit;
using ConnectFour;
using System;

namespace ConnectFour.Tests
{
    public class GameStateTests
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {

            var gameState = new GameState();


            var result = gameState.CheckForWin();


            Assert.Equal(GameState.WinState.No_Winner, result);

        }

        [Fact]
        public void CheckForWin_TieGame()
        {

            var gameState = new GameState();

            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    gameState.PlayPiece(col);
                }
            }


            var result = gameState.CheckForWin();


            Assert.Equal(GameState.WinState.Tie, result);
        }
    }
}