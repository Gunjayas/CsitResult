using CsitResult.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsitResult.Data.Services
{
    public class InMemoryStudentData : IStudentData
    {
        List<Student> students;

        public InMemoryStudentData()
        {
            students = new List<Student>() 
            {
             new Student {Id=1,Name = "Tom", SymbolNumber ="001"},
             new Student {Id=2,Name = "Dick", SymbolNumber ="002"},
             new Student {Id=3,Name = "Harry", SymbolNumber ="003"}

            };
        }

        public void Add(Student student)
        {
            students.Add(student);
            student.Id = students.Max(r => r.Id) + 1;
        }

        public Student Get(int id)
        {
            return students.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return students.OrderBy(r=>r.Name);
        }

        public void Update(Student student)
        {
            var existing = Get(student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.SymbolNumber = student.SymbolNumber;
            }
        }
        public void Delete(int id)
        {
            var student = Get(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
}
