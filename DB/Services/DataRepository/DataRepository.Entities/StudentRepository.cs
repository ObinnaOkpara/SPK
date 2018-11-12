using DB.Services.Interfaces.Interfaces.Entities;
using System.Linq;

namespace DB.Services.DataRepository
{
    public class StudentRepository : Repository<student>, IStudentRepository
    {
        public StudentRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }


        public IQueryable<student> GetStudentByName(string name)
        {
            return GetData.students.Where(s => s.firstname == name || s.lastname == name);
        }
    }
}
