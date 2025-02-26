using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.Data.Repositories.IRepositories;
using inventory.Data;
using inventory.Data.Repositories;

namespace InfastructureLayer.Repositories
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private AppDbContext _db;
        public AppUserRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AppUser obj)
        {
            _db.AppUsers.Update(obj);
        }
    }
}
