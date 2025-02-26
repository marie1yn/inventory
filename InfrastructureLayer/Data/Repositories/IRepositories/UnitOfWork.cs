using InfastructureLayer.Data.Repositories.IRepositories;
using InfastructureLayer.Repositories;
using inventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Data.Repositories.IRepositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext dbContext;
        public IAppUserRepository userRepository { get; private set; }
        public ILoginRepository programRepository { get; private set; }
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            userRepository ??= new AppUserRepository(dbContext);
            programRepository ??= new InfastructureLayer.Repositories.LoginRepository(dbContext);
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
