using gestor_de_rh01.BD.Domain.Entities;
using gestor_de_rh01.BD.Infrastructure.Contexts;


namespace gestor_de_rh01.BD.services
{
    public interface ILoginServices
    {
        //f
        List<Loginrh> Consultar(string filtro = "");
        (bool Ok, string message) Crear(Loginrh data);
        (bool Ok, string message) Eliminar(int Id);
    }

    public class LoginServices : ILoginServices
    {
        private readonly IGestorrhhDbcontext dbContext;

        public LoginServices(IGestorrhhDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region 

        public (bool Ok, string message) Crear(Loginrh data)
        {
            this.dbContext.Loginrhs.Add(data);
            var response = this.dbContext.SaveChanges() > 0;
            return (response, response ? "Se Guardo Correctamente" : "No Guardo");
        }

        public (bool Ok, string message) Eliminar(int Id)
        {
            var response = false;
            var data = this.dbContext.Loginrhs.FirstOrDefault(x => x.Id == Id);
            if (data != null)
            {
                this.dbContext.Loginrhs.Remove(data);
                response = this.dbContext.SaveChanges() > 0;
            }
            return (response, response ? "Eliminado" : "No Eliminó");
        }

        public List<Loginrh> Consultar(string filtro = "")
        {
            return this.dbContext.Loginrhs.
                Where(x => x.usuario.Contains(filtro))
                .ToList();
        }
        #endregion
    }
}