using E_library.Models;
using System;
using System.Linq;
using E_library.Services.FilteringService;

namespace E_library.Services
{
    public class FilteredResultPrinter<TResult, TFilter>
       where TResult : AbstractPublication
   {
       private readonly IFilteringService<TResult, TFilter> _service;

       public FilteredResultPrinter(IFilteringService<TResult, TFilter> service)
       {
           _service = service;
       }

       public void Print(TFilter filter)
        {
            var result = _service.GetPublications(filter).ToArray();

            Console.WriteLine("Результаты поиска:");
            if (!result.Any())
            {
                Console.WriteLine("Ничего не найдено");
                return;
            }

            foreach (var entity in result)
            {
                Console.WriteLine($"Название: {entity.Name}");
            }
        }
    }
}
