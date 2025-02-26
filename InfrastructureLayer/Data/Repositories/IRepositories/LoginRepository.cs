using System;
using inventory.Data;
using inventory.Data.Repositories;
using InfastructureLayer.Data.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;



namespace InfastructureLayer.Repositories
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        private AppDbContext _db;
        public LoginRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Login obj)
        {
            throw new NotImplementedException();
        }

        /* 
         public void Update(Login obj)
         {
             _db.Programs.Update(obj);
         }

         public void Update(Login obj)
         {
             throw new NotImplementedException();
         }
        */
    }
}
