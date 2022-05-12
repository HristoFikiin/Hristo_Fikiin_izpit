using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer;

namespace DataLayer
{
    public class GenreContext : IDB<Genre, int>
    {
        private PlayersDBContext _context;
        public GenreContext(PlayersDBContext context)
        {
            this._context = context;
        }

        public void Create(Genre item)
        {
            try
            {
                _context.Genres.Add(item);
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
                Genre genreFromDB = Read(key);
                _context.Remove(genreFromDB);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Genre Read(int key)
        {
            try
            {
                return _context.Genres.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Genre> ReadAll()
        {
            try
            {
                return _context.Genres.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Genre item)
        {
            try
            {
                Genre genreFromDB = Read(item.ID);

                _context.Entry(genreFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
