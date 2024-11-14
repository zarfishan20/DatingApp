using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //primary constructor
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<AppUser> Users { get; set; }
    }
}