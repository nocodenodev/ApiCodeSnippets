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
    }
}
