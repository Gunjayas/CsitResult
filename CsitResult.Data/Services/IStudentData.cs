using CsitResult.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsitResult.Data.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
