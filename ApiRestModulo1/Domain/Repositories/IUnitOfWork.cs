using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestModulo1.Domain.Repositories
{
    interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
