using E_library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibraryTests.InstanciatedTestData
{
    public static class MagazineData
    {
        public static IEnumerable<Magazine> GetItems()
        {
            return new[]
            {
                new Magazine
                {
                    Id = 1,
                    Year = 2020,
                    Name = "Строительство"
                },
                new Magazine
                {
                    Id = 2,
                    Year = 2019,
                    Name = "Высотные здания"
                },
                new Magazine
                {
                    Id = 3,
                    Year = 2018,
                    Name = "Низенькие здания"
                }
            };
        }
    }
}
