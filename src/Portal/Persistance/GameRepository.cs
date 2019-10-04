using Portal.Common;
using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Persistance
{
    public class GameRepository
    {
        private readonly LiteDbContext _db;
        public GameRepository(LiteDbContext db)
        {
            _db = db;
        }

        public void CreateGame(Player playerX, Player playerO)
        {
            var game = new Game(playerX, playerO);
            var gameCollection = _db.Context.GetCollection<Game>();
            gameCollection.Insert(game);
        }

        public IList<Game> GetAllGames()
        {
            var gameCollection = _db.Context.GetCollection<Game>();
            return gameCollection.FindAll().ToList();
        }

        public Game GetGame(string gameId)
        {
            var gameCollection = _db.Context.GetCollection<Game>();
            return gameCollection.FindById(gameId);
        }
    }
}
