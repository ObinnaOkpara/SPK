﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.Interfaces.Interfaces.Entities
{
   public interface ISchool_SubjectsRepository : IRepository<school_subjects>
    {
       bool CheckIfItExists(string subject_Name);
    }
}
