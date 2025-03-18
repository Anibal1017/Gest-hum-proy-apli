using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_de_rh01.BD.Domain.Entities;
using gestor_de_rh01.BD.Infrastructure.Contexts;


namespace gestor_de_rh01.BD.services
{
    public interface ITelegramaServices
    {
        //f
        List<TelegramaEn> Consultar(string filtro = "");
        (bool Ok, string message) Crear(TelegramaEn data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class TelegramaServices : ITelegramaServices
    {
        private readonly IGestorrhhDbcontext dbContext;

        public TelegramaServices(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(TelegramaEn data)
        {
            this.dbContext.TelegramaEns.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.TelegramaEns.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.TelegramaEns.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<TelegramaEn> Consultar(string filtro = "")
        {
            return this.dbContext.TelegramaEns.
                Where(x => x.Nomtelegrama.Contains(filtro))
                .ToList();
        }
        #endregion
    }
}

/*
     public interface ITelegramaServices
    {
        //f
        List<TelegramaEn> Consultar(string filtro = "");
        (bool Ok, string message) Crear(TelegramaEn data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class TelegramaServices : ITelegramaServices
    {
        private readonly IGestorrhhDbcontext dbContext;

        public TelegramaServices(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(TelegramaEn data)
        {
            this.dbContext.TelegramaEns.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.TelegramaEns.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.TelegramaEns.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<TelegramaEn> Consultar(string filtro = "")
        {
            return this.dbContext.TelegramaEns.
                Where(x => x.Nomtelegrama.Contains(filtro))
                .ToList();
        }
        #endregion
 
 
 */