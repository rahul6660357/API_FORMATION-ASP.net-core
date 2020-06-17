﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APICORE_WEBAPP.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
         : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    
}
}
