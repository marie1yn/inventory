using DomainLayer.Models;
using InfastructureLayer.Data.Repositories.IRepositories;

namespace InfastructureLayer.Repositories
{
    public interface ILoginRepository : IRepository<Login>
    {
        void Update(Login obj);

    }
   
}