﻿using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IPrincipalRepository PrincipalRepository { get; }
        IUserRepository UserRepository { get; }
        ISchool_SubjectsRepository School_SubjectsRepository { get; }
        ISessionRepository SessionRepository { get; }
        ITeachers_ClassesRepository Teachers_ClassesRepository { get; }
        IClassRepository dClassRepository { get; }
        ISubjectsRepository SubjectsRepository { get; }
        //add other repos here

        Task<int> Save();
    }

}
