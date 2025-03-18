using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_de_rh01.BD.Domain.Entities;
using gestor_de_rh01.BD.Infrastructure.Contexts;


namespace gestor_de_rh01.BD.services
{
    public interface IGestorrhhServices
    {
        //f
        List<GestorRhh> Consultar(string filtro = "");
        (bool Ok, string message) Crear(GestorRhh data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class GestorrhhServices : IGestorrhhServices
    {
        private readonly IGestorrhhDbcontext dbContext;

        public GestorrhhServices(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(GestorRhh data)
        {
            this.dbContext.GestorRhhs.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.GestorRhhs.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.GestorRhhs.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<GestorRhh> Consultar(string filtro = "")
        {
            return this.dbContext.GestorRhhs.
                Where(x => x.Nombre.Contains(filtro))
                .ToList();
        }
        #endregion
    }
}