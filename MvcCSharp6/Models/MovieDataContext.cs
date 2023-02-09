using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCSharp6.Models
{
    public class MovieDataContext : DbContext
    {
        // constructor
        public MovieDataContext(DbContextOptions<MovieDataContext> options) : base (options)
        {

        }

        public DbSet<MovieModel> responses { get; set; }
    }
}