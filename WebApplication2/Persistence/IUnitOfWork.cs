using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
