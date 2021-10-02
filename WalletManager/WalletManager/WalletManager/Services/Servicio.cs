using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class Servicio<TEntidad> where TEntidad : class
    {
        private Repositorio<TEntidad> _repositorio;

        public Servicio(Repositorio<TEntidad> repositorio)
        {
            _repositorio = repositorio;
        }
        public bool Insert(TEntidad entidad)
        {
            var filasAfectadas = _repositorio.Insert(entidad);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
        public TEntidad GetById(int id)
        {
            return _repositorio.GetById(id);
        }
        public IEnumerable<TEntidad> Find(Expression<Func<TEntidad, bool>> predicado)
        {
            return _repositorio.Find(predicado);
        }
        public void Delete(TEntidad entidadABorrar)
        {
            _repositorio.Delete(entidadABorrar);
        }
        public void Update(TEntidad entidad)
        {
            _repositorio.Update(entidad);
        }
        public IEnumerable<TEntidad> GetAll()
        {
            return _repositorio.GetAll();
        }
    }
}
