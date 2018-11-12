using DB.Services.Interfaces;
using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Model1 _dbContext;

        public UnitOfWork(Model1 dbContext)
        {
            _dbContext = dbContext;
            StudentRepository = new StudentRepository(_dbContext);
            //add other repositories here
        }

        //add other repos here
        public IStudentRepository StudentRepository
        {
            get;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }

}
