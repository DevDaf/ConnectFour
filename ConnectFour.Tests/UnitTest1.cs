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
            // Arrange
            var gameState = new GameState();

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.No_Winner, result);

        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();

            // Play pieces to fill the board without a win
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    gameState.PlayPiece(col);
                }
            }

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.Tie, result);
        }
    }
}