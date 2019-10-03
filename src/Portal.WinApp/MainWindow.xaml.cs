using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Portal.WinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var player1 = new Player("X", MarkerType.X);
            var player2 = new Player("O", MarkerType.O);

            Game = new Game(player1, player2);
        }

        public Game Game { get; private set; }

        public void CheckWinner()
        {
            var result = Game.GetWinner();
            switch (result)
            {
                case GameResult.Draw:
                    ResultMessage.Content = "Draw";
                    break;
                case GameResult.XWins:

                    ResultMessage.Content = "X wins";
                    break;
                case GameResult.OWins:

                    ResultMessage.Content = "O wins";
                    break;
                case GameResult.Play:
                    break;
                default:
                    break;
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[0].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.One));              
                Button1.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[1].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Two));
                Button2.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[2].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Three));
                Button3.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[3].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Four));
                Button4.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[4].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Five));
                Button5.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[5].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Six));
                Button6.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[6].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Seven));
                Button7.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[7].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Eight));
                Button8.Content = player.Marker.ToString();
                CheckWinner();
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (Game.Board.Positions[8].State == PositionState.Empty)
            {
                var player = Game.GetNextTurn();
                Game.AddMove(new Move(player, PositionType.Nine));
                Button9.Content = player.Marker.ToString();
                CheckWinner();
            }
        }
    }
}
