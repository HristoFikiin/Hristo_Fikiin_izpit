using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer;

namespace DataLayer
{
    public class GameContext : IDB<Game, int>
    {
        private PlayersDBContext _context;
        public GameContext(PlayersDBContext context)
        {
            this._context = context;
        }

        public void Create(Game item)
        {
            try
            {
                _context.Games.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Game gameFromDB = Read(key);
                _context.Remove(gameFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Game Read(int key)
        {
            try
            {
                return _context.Games.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Game> ReadAll()
        {
            try
            {
                return _context.Games.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Game item)
        {
            try
            {
                Game gameFromDB = Read(item.ID);

                _context.Entry(gameFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
