using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_de_rh01.BD.Domain.Entities;
using gestor_de_rh01.BD.Infrastructure.Contexts;

namespace gestor_de_rh01.BD.services
{
    public interface IPersonalservices
    {
        //f
        List<Personalrhh> Consultar(string filtro = "");
        (bool Ok, string message) Crear(Personalrhh data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class Personalservices : IPersonalservices
    {
        private readonly IGestorrhhDbcontext dbContext;

        public Personalservices(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(Personalrhh data)
        {
            this.dbContext.Personalrhhs.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.Personalrhhs.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.Personalrhhs.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<Personalrhh> Consultar(string filtro = "")
        {
            return this.dbContext.Personalrhhs.
                Where(x => x.NombreP.Contains(filtro))
                .ToList();
        }
        #endregion
    }
}