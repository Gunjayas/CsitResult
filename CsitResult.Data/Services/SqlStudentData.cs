using CsitResult.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsitResult.Data.Services
{
    public class SqlStudentData : IStudentData
    {
        private CsitResultDbContext db;

        public SqlStudentData(CsitResultDbContext db)
        {
            this.db = db;
        }
        public void Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public Student Get(int id)
        {
            return db.Students.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return from r in db.Students
                   orderby r.Name
                   select r;
        }

        public void Update(Student student)
        {
            var entry = db.Entry(student);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
