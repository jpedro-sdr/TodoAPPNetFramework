using System.Collections.Generic;
using System.Linq;
using TodoApplicationNetFramework.DbContext.Contexts;
using TodoApplicationNetFramework.Models.Entidades;

namespace TodoApplicationNetFramework.DbContext.Repositories
{
    public class TimeRepository
    {
        private readonly TodoContext _context;

        public TimeRepository()
        {
            _context = new TodoContext();
        }

        public IEnumerable<Time> GetAll()
        {
            return _context.Times.ToList();
        }
        
        public void Add(Time entidade)
        {
            _context.Times.Add(entidade);
            _context.SaveChanges();
        }

        
        public void Update(Time entidade)
        {
            _context.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            var entidade = _context.Times.Find(id);
            if (entidade != null)
            {
                _context.Times.Remove(entidade);
                _context.SaveChanges();
            }
        }
        
    }
}