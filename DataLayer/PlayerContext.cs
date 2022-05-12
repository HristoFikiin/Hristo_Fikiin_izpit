using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer;

namespace DataLayer
{
    public class PlayerContext : IDB<Player, int>
    {
        private PlayersDBContext _context;
        public PlayerContext(PlayersDBContext context)
        {
            this._context = context;
        }

        public void Create(Player item)
        {
            try
            {
                _context.Players.Add(item);
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
                Player playerFromDB = Read(key);
                _context.Remove(playerFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Player pleyerche)
        {
            try
            {
                _context.Players.Remove(pleyerche);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Player Read(int key)
        {
            try
            {
                return _context.Players.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Player> ReadAll()
        {
            try
            {
                return _context.Players.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Player item)
        {
            try
            {
                Player playerFromDB = Read(item.ID);

                _context.Entry(playerFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
