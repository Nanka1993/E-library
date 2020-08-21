using System;
using System.Collections.Generic;
using System.Linq;

namespace E_library.Services.Repository
{
    public interface IReader<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetItems(); // получение всех объектов
        IQueryable<T> GetQuery();
    }
}