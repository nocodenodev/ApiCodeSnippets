using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiCodeSnippets.Models;

namespace ApiCodeSnippets.Data
{
    public class CodeSnippetsContext : DbContext
    {
        public CodeSnippetsContext (DbContextOptions<CodeSnippetsContext> options)
            : base(options)
        {
        }

        public DbSet<ApiCodeSnippets.Models.CodeSnippet> CodeSnippet { get; set; } = default!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodeSnippet>().HasData(
                    new CodeSnippet
                    {
                        Id = 1,
                        Title = "Sum function",
                        ProgrammingLanguage = "TypeScript",
                        Tag = "Functions",
                        Description = "Simple sum function snippet",
                        Status = "Active",
                        Snippet = "const sum = (x, y) => {return x + y;}"
                    },
                    new CodeSnippet
                    {
                        Id = 2,
                        Title = "Multiply function",
                        ProgrammingLanguage = "TypeScript",
                        Tag = "Functions",
                        Description = "Simple multiply function snippet",
                        Status = "Active",
                        Snippet = "const multiply = (x, y) => {return x * y;}"
                    }
                );
        }
    }
}
