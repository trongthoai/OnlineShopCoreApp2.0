﻿using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Infrastructure.Interfaces;

namespace WebCoreApp.Data.EF
{
    class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
