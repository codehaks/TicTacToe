using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain;

public class GameHost
{
    public HashSet<Player> Players { get; set; }

    public IList<Game> Games { get; set; }

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void StartGame(Player playerX,Player playerO)
    {
        var game = new Game(playerX, playerO);
        Games.Add(game);
    }

}
