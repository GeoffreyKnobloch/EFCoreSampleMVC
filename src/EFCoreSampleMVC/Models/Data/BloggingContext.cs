using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSampleMVC.Models.Data
{

    /// <summary>
    /// Service permitting direct access to database.
    /// </summary>
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; } // 'Table of Blogs'
        public DbSet<Post> Posts { get; set; } // 'Table of Posts'

    }
}
