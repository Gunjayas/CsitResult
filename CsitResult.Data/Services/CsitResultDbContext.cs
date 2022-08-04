using CsitResult.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsitResult.Data.Services
{
    public class CsitResultDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
