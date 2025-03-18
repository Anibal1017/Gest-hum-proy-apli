using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_de_rh01.BD.Domain.Entities;
using gestor_de_rh01.BD.Infrastructure.Contexts;



namespace gestor_de_rh01.BD.services
{
    public interface IListcompService
    {
        //f
        List<Listacompra> Consultar(string filtro = "");
        (bool Ok, string message) Crear(Listacompra data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class ListcompService : IListcompService
    {
        private readonly IGestorrhhDbcontext dbContext;

        public ListcompService(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(Listacompra data)
        {
            this.dbContext.Listcompras.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.Listcompras.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.Listcompras.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<Listacompra> Consultar(string filtro = "")
        {
            return this.dbContext.Listcompras.
                Where(x => x.Nombreact.Contains(filtro))
                .ToList();
        }
        #endregion
    }
}