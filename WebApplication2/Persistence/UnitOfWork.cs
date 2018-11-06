using QuizApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QuizAppDbContext context;

        public UnitOfWork(QuizAppDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
