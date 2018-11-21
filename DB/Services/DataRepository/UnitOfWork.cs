using DB.Services.DataRepository.DataRepository.Entities;
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
            TeacherRepository = new TeacherRepository(_dbContext);
            PrincipalRepository = new PrincipalRepository(_dbContext);
            UserRepository = new UserRepository(_dbContext);
            School_SubjectsRepository = new School_SubjectsRepository(_dbContext);
            SessionRepository = new SessionRepository(_dbContext);
            Teachers_ClassesRepository = new Teachers_ClassesRepository(_dbContext);
            //add other repositories here
        }

        //add other repos interface here
        public IStudentRepository StudentRepository
        {
            get;
        }

        public ITeacherRepository TeacherRepository
        {
            get;
        }

        public IPrincipalRepository PrincipalRepository
        {
            get;
        }

        public IUserRepository UserRepository
        {
            get;
        }

        public ISchool_SubjectsRepository School_SubjectsRepository
        {
            get;
        }

        public ISessionRepository SessionRepository
        {
            get;
        }

        public ITeachers_ClassesRepository Teachers_ClassesRepository
        {
            get;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Task<int> Save()
        {
            return _dbContext.SaveChangesAsync();
        }
    }

}
