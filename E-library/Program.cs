using E_library.Database;
using E_library.Services;
using System;
using System.Linq;
using E_library.Dto.Filters;
using E_library.Models;
using E_library.Services.FilteringService;
using E_library.Services.Repository;
using Microsoft.EntityFrameworkCore;

namespace E_library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using var context = new LibraryContext();

                IReader<Magazine> readerMagazine = new ContextReader<Magazine>(context); 

                IDataSeeder seeder = new ContextDataSeeder(context);
                var seedingResult = seeder.Seed();
                Console.WriteLine(seedingResult);

                var magazineFilter = new MagazineFilter
                {
                    YearEquals = 2020,
                    NameContains = "высот"
                };
                var magazineService = new MagazinesFilteringService(readerMagazine);
                var magazinePrinter = new FilteredResultPrinter<Magazine, MagazineFilter>(magazineService);
                magazinePrinter.Print(magazineFilter);
                //PrintPublicationFilteringResult(magazineFilter, magazineService);
                //magazineFilter.YearEquals = null;
                //ShowMagazinesFilteringResult(magazineFilter, context);
                //ShowMagazinesFilteringResult(null, context);



                //ShowBooksFilteringResult(bookFilter, context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static void PrintPublicationFilteringResult<TResult, TFilter>(TFilter filter,
            IFilteringService<TResult, TFilter> service)
            where TResult : AbstractPublication
        {
            var result = service.GetPublications(filter).ToArray();

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

        //private static void PrintBooksFilteringResult(BookFilter filter, LibraryContext context)
        //{
        //    var filteringService = new BooksFilteringService(context);

        //    var filteringResult = filteringService.GetPublications(filter).ToArray();

        //    Console.WriteLine("Результаты поиска:");
        //    if (filteringResult?.Any() == true)
        //    {
        //        foreach (var entity in filteringResult)
        //        {
        //            Console.WriteLine($"Название: {entity.Name}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ничего не найдено");
        //    }
        //}
    }
}