using InfastructureLayer.Data.Repositories.IRepositories;
using inventory.Data;

namespace InfrastructureLayer.Data.Repositories.IRepositories
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        void Update(AppUser obj);
    }
}