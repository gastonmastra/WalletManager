using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;

namespace WalletManager.Repository
{
    public class Repositorio<TEntidad> where TEntidad : class
    {
        private readonly DBContext db;

        public Repositorio(DBContext dbContext)
        {
            db = dbContext;
        }
        public int Insert(TEntidad entidad)
        {
            db.Set<TEntidad>().Add(entidad);
            return db.SaveChanges();
        }
        public TEntidad GetById(int id)
        {
            return db.Set<TEntidad>().Find(id);
        }
        public IEnumerable<TEntidad> Find(Expression<Func<TEntidad, bool>> predicado)
        {
            return db.Set<TEntidad>().Where(predicado);
        }
        public void Delete(TEntidad entidadABorrar)
        {
            db.Set<TEntidad>().Remove(entidadABorrar);
            db.SaveChanges();
        }
        public void Update(TEntidad entidad)
        {
            db.Entry(entidad).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IEnumerable<TEntidad> GetAll()
        {
            return db.Set<TEntidad>().ToList();
        }
    }
}
